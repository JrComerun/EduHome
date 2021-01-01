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
            int countevents = _db.Events.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countevents;
            return View(_db.Events.Where(e => e.IsDeleted == false).Include(e => e.DetailOfEvent).ToList());
        }

        #region Create Event
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM)
        {
            //**************is Non Valid for Events******************//
            if (eventVM.Event.Photo == null) return IsNonValid("", "Please select PHOTO!!!");
            if (!eventVM.Event.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (eventVM.Event.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            bool isExist = _db.Events.Where(c => c.IsDeleted == false).Any(c => c.Name.ToLower() == eventVM.Event.Name.ToLower());
            if (isExist) return IsNonValid("", "This events is already exist");
            //**************is Non Valid for Spikers******************//
            if (!eventVM.Spiker.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (eventVM.Spiker.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            bool isExistSpiker = _db.SpikersOfEvents.Where(c => c.IsDeleted == false).Any(c => c.FullName.ToLower() == eventVM.Spiker.FullName.ToLower());
            if (isExistSpiker) return IsNonValid("", "This spiker is already exist");
            //*********************************************************//
            //*********************Create Event***********************//
            string folder = Path.Combine("assets", "img", "event");
            string filename = await eventVM.Event.Photo.SaveImageAsync(_env.WebRootPath, folder);
            eventVM.Event.Image = filename;
            eventVM.Event.IsDeleted = false;
            await _db.Events.AddAsync(eventVM.Event);
            await _db.SaveChangesAsync();
            eventVM.DetailOfEvent.EventId = eventVM.Event.Id;
            eventVM.DetailOfEvent.IsDeleted = false;
            await _db.DetailOfEvents.AddAsync(eventVM.DetailOfEvent);
            await _db.SaveChangesAsync();
            //*****************************************************//
            //*************Create Spiker for this Event************//
            string folderSpiker = Path.Combine("assets", "img", "event");
            string filenameSpiker = await eventVM.Spiker.Photo.SaveImageAsync(_env.WebRootPath, folderSpiker);
            eventVM.Spiker.Image = filenameSpiker;
            eventVM.Spiker.IsDeleted = false;
            eventVM.Spiker.DetailOfEventId = eventVM.DetailOfEvent.Id;
            await _db.SpikersOfEvents.AddAsync(eventVM.Spiker);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Event
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Event events = _db.Events.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).FirstOrDefault(c => c.Id == id);
            if (events == null) return RedirectToAction(nameof(Index));

            return View(events);
        }
        #endregion

        #region Delete Event
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Event events = _db.Events.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).FirstOrDefault(c => c.Id == id);
            if (events == null) return RedirectToAction(nameof(Index));
            return View(events);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Event events = _db.Events.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).FirstOrDefault(c => c.Id == id);
            if (events == null) return RedirectToAction(nameof(Index));

            int countEvent = _db.Events.Where(s => s.IsDeleted == false).Count();

            if (countEvent > 50)
            {
                string folder = Path.Combine("assets", "img", "event");
                string path = Path.Combine(_env.WebRootPath, folder, events.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.Events.Remove(events);
            }
            else if (countEvent > 3 && countEvent <= 50)
            {
                events.IsDeleted = true;
                events.DeletedTime = DateTime.UtcNow;
                events.DetailOfEvent.IsDeleted = true;
                events.DetailOfEvent.DeletedTime = DateTime.UtcNow;
            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Event
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            EventVM eventVM = new EventVM
            {
                Event= _db.Events.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id),
                DetailOfEvent= _db.DetailOfEvents.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.EventId == id),
            };

            if (eventVM.Event == null) return RedirectToAction(nameof(Index));

            return View(eventVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, EventVM eventVM)
        {

           if (id == null) return RedirectToAction(nameof(Index));
            EventVM dbEventVM = new EventVM
            {
                Event = _db.Events.Where(c => c.IsDeleted == false).Include(c => c.DetailOfEvent).FirstOrDefault(c => c.Id == id),
                DetailOfEvent = _db.DetailOfEvents.Where(c => c.IsDeleted == false).Include(c => c.Event).FirstOrDefault(c => c.EventId == id),
            };

            if (dbEventVM.Event == null) return RedirectToAction(nameof(Index));
            if (eventVM.Event.Photo != null)
            {

                if (!eventVM.Event.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", dbEventVM);
                if (eventVM.Event.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!", dbEventVM);

                string folder = Path.Combine("assets", "img", "event");
                string filename = await eventVM.Event.Photo.SaveImageAsync(_env.WebRootPath, folder);


                int countEvents = _db.Events.Where(s => s.IsDeleted == false).Count();
                if (countEvents > 50)
                {
                    string path = Path.Combine(_env.WebRootPath, folder, dbEventVM.Event.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);

                    }
                    _db.Events.Remove(eventVM.Event);
                }
                dbEventVM.Event.Image = filename;
            }
            bool isExist = _db.Events.Where(c => c.IsDeleted == false)
                .Any(c => c.Name.ToLower() == eventVM.Event.Name.ToLower() && c.Id != id);

            if (isExist) return IsNonValid("", "This Event is already exist", dbEventVM);
            dbEventVM.Event.Name = eventVM.Event.Name;
            dbEventVM.Event.StartingTime = eventVM.Event.StartingTime;
            dbEventVM.Event.EndTime = eventVM.Event.EndTime;
            dbEventVM.Event.Venue = eventVM.Event.Venue;
            dbEventVM.DetailOfEvent.Decscription = eventVM.DetailOfEvent.Decscription;
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
