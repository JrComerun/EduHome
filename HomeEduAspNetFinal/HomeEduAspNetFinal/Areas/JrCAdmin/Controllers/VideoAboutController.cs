using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    [Authorize(Roles = "Admin")]
    public class VideoAboutController : Controller
    {

        private readonly AppDbContext _db;
        
        public VideoAboutController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.VideoTours.FirstOrDefault());
        }
        public IActionResult Update()
        {
            return View(_db.VideoTours.FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(VideoTour tour)
        {
            VideoTour dbTour = _db.VideoTours.FirstOrDefault();
            if (!ModelState.IsValid) return View(dbTour); 
            dbTour.VideoTitle = tour.VideoTitle;
            dbTour.BoardTitle = tour.BoardTitle;
            dbTour.VideoLink = tour.VideoLink;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
