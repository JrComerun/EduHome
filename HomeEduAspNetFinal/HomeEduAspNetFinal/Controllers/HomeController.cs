using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;
        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                HomeSliders = _db.HomeSliders.Where(s=>s.IsDeleted==false).ToList(),
            };
            return View(homeVM);
        }

        public IActionResult GlobalSearch(string search)
        {
            if (search == null) return NotFound();
            SearchVM searchVM = new SearchVM
            {
                Teachers = _db.Teachers.Where(t => t.IsDeleted == false && t.FullName.Contains(search)).Take(3).ToList(),
                Events = _db.Events.Where(t => t.IsDeleted == false && t.Name.Contains(search)).Take(3).ToList(),
                Courses=_db.Courses.Where(t=>t.IsDeleted==false&&t.Name.Contains(search)).Take(3).ToList(),
            };
            return PartialView("_GlobalSearchPartial",searchVM);
        }
        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
