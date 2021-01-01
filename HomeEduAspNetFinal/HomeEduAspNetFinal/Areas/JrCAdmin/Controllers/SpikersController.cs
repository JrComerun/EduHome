using Fiorello.Extensions;
using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    [Authorize(Roles = "Admin")]
    public class SpikersController : Controller
    {
       
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SpikersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            
            return View(_db.SpikersOfEvents.Where(e => e.IsDeleted == false).Include(e => e.DetailOfEvent).ThenInclude(s=>s.Event).ToList());
        }
        #region Create Spiker
        public IActionResult Create()
        {
            EventVM eventVM = new EventVM
            {
                Events = _db.Events.Where(e => e.IsDeleted == false).Include(e => e.DetailOfEvent).ToList(),
            };
            return View(eventVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM, int? eventId)
        {
            if (eventId == null) return IsNonValid("", "Please select which of event!!");

            if (!eventVM.Spiker.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (eventVM.Spiker.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            bool isExist = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Any(c => c.FullName.ToLower() == eventVM.Spiker.FullName.ToLower());
            if (isExist) return IsNonValid("", "This spiker is already exist");
            string folder = Path.Combine("assets", "img", "event");
            string filename = await eventVM.Spiker.Photo.SaveImageAsync(_env.WebRootPath, folder);
            eventVM.Spiker.Image = filename;
            eventVM.Spiker.IsDeleted = false;
            eventVM.Spiker.DetailOfEventId = (int)eventId;
            await _db.SpikersOfEvents.AddAsync(eventVM.Spiker);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Spiker
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            SpikersOfEvent spiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).
                ThenInclude(s => s.Event).FirstOrDefault(c => c.Id == id);
            if (spiker == null) return RedirectToAction(nameof(Index));

            return View(spiker);
        }
        #endregion

        #region Delete Spiker
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            SpikersOfEvent spiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).
                ThenInclude(s => s.Event).FirstOrDefault(c => c.Id == id);
            if (spiker == null) return RedirectToAction(nameof(Index));

            return View(spiker);
        }
        #endregion




        #region My IsNonValid Metods
        public ActionResult IsNonValid(string errorName, string errorContent)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View();
        }
        public ActionResult IsNonValid(string errorName, string errorContent, object returnObj)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View(returnObj);
        }
        #endregion
    }
}
