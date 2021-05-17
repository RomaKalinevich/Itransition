using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class RewardController : Controller
    {
        CompanyContext db = new CompanyContext();
        public IActionResult reward() => View();
        [HttpPost]
        public async Task<IActionResult> reward(Guid Id, RewardViewModel model)
        {
            Reward reward = new Reward(Id, model.rewardDesc, model.rewardPrice);
            db.AddRange(reward);
            db.SaveChanges();
            return RedirectToAction("Details", "Home", new { id = Id });
        }
    }
}
