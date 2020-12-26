using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            DetailOfEvent detail = _db.DetailOfEvents.Include(d => d.Event).FirstOrDefault(c => c.EventId == id);
            if (detail == null) return NotFound();
            return View(detail);
        }
    }
}
