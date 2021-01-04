using HomeEduAspNetFinal.Extensions;
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
        public IActionResult Index(int page=1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.SpikersOfEvents.Where(s => s.IsDeleted == false).Count() / 4);
            ViewBag.Page = page;
            return View(_db.SpikersOfEvents.Where(e => e.IsDeleted == false).Include(e => e.DetailOfEvent).ThenInclude(s=>s.Event).OrderByDescending(d => d.Id).Skip(((int)page - 1) * 4).Take(4).ToList());
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            SpikersOfEvent spiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).
                ThenInclude(s => s.Event).FirstOrDefault(c => c.Id == id);
            if (spiker == null) return RedirectToAction(nameof(Index));

            int countSpiker = _db.SpikersOfEvents.Where(s => s.IsDeleted == false).Count();

            if (countSpiker > 50)
            {
                string folder = Path.Combine("assets", "img", "event");
                string path = Path.Combine(_env.WebRootPath, folder, spiker.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.SpikersOfEvents.Remove(spiker);
            }
            else if (countSpiker > 3 && countSpiker <= 50)
            {
                spiker.IsDeleted = true;
                spiker.DeletedTime = DateTime.UtcNow;
                
            }
            
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Spiker
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            EventVM eventVM = new EventVM
            {
                Events = _db.Events.Where(e => e.IsDeleted == false).Include(e => e.DetailOfEvent).ToList(),
                Spiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).
                ThenInclude(s => s.Event).FirstOrDefault(c => c.Id == id),
            };

            if (eventVM.Spiker == null) return RedirectToAction(nameof(Index));

            return View(eventVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, EventVM eventVM , int? eventId)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            EventVM dbEventVM = new EventVM
            {
                Spiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).
                ThenInclude(s => s.Event).FirstOrDefault(c => c.Id == id),
            };

            if (dbEventVM.Spiker == null) return RedirectToAction(nameof(Index));
            if (eventVM.Spiker.Photo != null)
            {

                if (!eventVM.Spiker.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", dbEventVM);
                if (eventVM.Spiker.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!", dbEventVM);

                string folder = Path.Combine("assets", "img", "event");
                string filename = await eventVM.Spiker.Photo.SaveImageAsync(_env.WebRootPath, folder);


                int countSpiker = _db.SpikersOfEvents.Where(s => s.IsDeleted == false).Count();
                if (countSpiker > 50)
                {
                    string path = Path.Combine(_env.WebRootPath, folder, dbEventVM.Spiker.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);

                    }

                }
                dbEventVM.Spiker.Image = filename;
            }
            bool isExist = _db.SpikersOfEvents.Where(c => c.IsDeleted == false)
                .Any(c => c.FullName.ToLower() == eventVM.Spiker.FullName.ToLower() && c.Id != id);

            if (isExist) return IsNonValid("", "This Spiker is already exist", dbEventVM);
            dbEventVM.Spiker.FullName = eventVM.Spiker.FullName;
            dbEventVM.Spiker.Profession = eventVM.Spiker.Profession;
            dbEventVM.Spiker.DetailOfEventId = (int)eventId;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
