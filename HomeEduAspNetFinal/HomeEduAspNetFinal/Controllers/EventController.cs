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

            DetailOfEvent detail = _db.DetailOfEvents.Include(d=>d.SpikersOfEvents).Include(d => d.Event).FirstOrDefault(c => c.EventId == id);
            if (detail == null) return NotFound();
            return View(detail);
        }
        public IActionResult Search(string search)
        {
            List<Event> model = _db.Events.Where(p => p.Name.Contains(search)).Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_EventSPartial", model);
        }
    }
}
