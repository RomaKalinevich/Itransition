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
                Company company = new Company(model.Name, model.mainImg, model.shortDesc, model.longDecs,
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
    }
}
