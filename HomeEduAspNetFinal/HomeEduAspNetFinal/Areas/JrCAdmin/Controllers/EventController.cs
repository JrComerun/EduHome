using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public EventController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            int countEvent = _db.Events.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countEvent;
            return View(_db.Events.Where(e=>e.IsDeleted==false).Include(e=>e.SpikersOfEvents).Include(e=>e.DetailOfEvent).ToList());
        }
    }
}
