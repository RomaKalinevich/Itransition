using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Controllers
{
    public class CompanyController : Controller
    {
        CompanyContext db = new CompanyContext();
        public Company Company { get; set; }
        public async Task<IActionResult> OnGetAsync(int companyId)
        {
            Company = await db.Company.FindAsync(companyId);
            if (Company == null)
            {
                return RedirectToPage("./AccessDenied");
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
