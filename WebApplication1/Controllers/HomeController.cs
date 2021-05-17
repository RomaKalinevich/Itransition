using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using WebApplication1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //UserManager<Company> _userManager;

        //public HomeController(UserManager<Company> userManager)
        //{
        //    _userManager = userManager;
        //}
        private readonly SignInManager<User> _signInManager;
        CompanyContext db = new CompanyContext();
        public HomeController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Company company = new Company(model.Name, model.mainImg, model.video, model.shortDesc, model.longDecs,
                                              model.price);
                db.AddRange(company);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index() => View(db.Company.ToArray());

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id != null)
            {
                Company company = await db.Company.FirstOrDefaultAsync(p => p.Id == id);
                if (company != null)
                    return View(company);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Company company)
        {
            db.Company.Update(company);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> Details(Guid id)
        {
            if (id != null)
            {
                List<Company> compModels = db.Company.Select(c => new Company { Id = c.Id, Name = c.Name, mainImg = c.mainImg, longDecs = c.longDecs, price = c.price, currentSum = c.currentSum}).Where(c => c.Id == id).ToList();
                List<Likes> Likes = db.Likes.Select(c => new Likes { likeUp = c.likeUp, likeDown = c.likeDown, CompanyId = c.CompanyId}).Where(c => c.CompanyId == id).ToList();
                List<Reward> Rewards = db.Reward.Select(s => new Reward { companyId = s.companyId, rewardDesc = s.rewardDesc, rewardPrice = s.rewardPrice }).Where(c => c.companyId == id).ToList();
                DetailsViewModel details;
                if (Likes.Count != 0)
                {
                    details = new DetailsViewModel { companies = compModels, likes = Likes, rewards = Rewards };
                    return View(details);
                }
                Likes like = new Likes { CompanyId = id, likeUp = 0, likeDown = 0 };
                db.AddRange(like);
                db.SaveChanges();
                Likes.Add(like);
                details = new DetailsViewModel { companies = compModels, likes = Likes };
                return View(details);
            }
            return NotFound();
        }
    }
}
