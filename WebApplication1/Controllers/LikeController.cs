using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LikeController : Controller
    {
        CompanyContext db = new CompanyContext();
        public async Task<IActionResult> upLike (Guid Id)
        {
            Likes result = db.Likes.Where(p => p.CompanyId == Id).FirstOrDefault();
            result.likeUp++;
            db.SaveChanges();
            return RedirectToAction("Details", "Home", new { id = Id });
        }
        public async Task<IActionResult> downLike(Guid Id)
        {
            Likes result = db.Likes.Where(p => p.CompanyId == Id).FirstOrDefault();
            result.likeDown++;
            db.SaveChanges();
            return RedirectToAction("Details", "Home", new { id = Id });
        }
    }
}
