using Fiorello.Extensions;
using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            int countSlider = _db.HomeSliders.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countSlider;
            return View(_db.HomeSliders.Where(s => s.IsDeleted == false).ToList());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeSlider slider)
        {
            //?sual vermek
            //if (!ModelState.IsValid) return NotFound();
            if (slider.Photo == null) return IsNonValid("Photo", "Please select PHOTO!!!");
            if (!slider.Photo.IsImage()) return IsNonValid("Photo", "Please select image type!!!");
            if (slider.Photo.MaxSize(200)) return IsNonValid("Photo", "Select PHOTO max-size 200!");

            string folder = Path.Combine("assets", "img", "slider");
            string filename = await slider.Photo.SaveImageAsync(_env.WebRootPath, folder);
            
            slider.BgImage = filename;
            slider.IsDeleted = false;
            await _db.HomeSliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public  IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
             HomeSlider slider = _db.HomeSliders.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (slider == null) return RedirectToAction(nameof(Index));

            return View(slider);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            HomeSlider slider = _db.HomeSliders.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (slider == null) return RedirectToAction(nameof(Index));

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            HomeSlider slider = _db.HomeSliders.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (slider == null) RedirectToAction(nameof(Index));
            int countSlider = _db.HomeSliders.Where(s=>s.IsDeleted==false).Count();
            
            if (countSlider > 3 )
            {
                string folder = Path.Combine("assets", "img", "slider");
                string path = Path.Combine(_env.WebRootPath, folder, slider.BgImage);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
        
                }
                _db.HomeSliders.Remove(slider);
            }
            else if(countSlider > 1&& countSlider <= 3)
            {
                slider.IsDeleted = true;
                slider.DeletedTime = DateTime.UtcNow;
            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            HomeSlider slider = _db.HomeSliders.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (slider == null) return RedirectToAction(nameof(Index));

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,HomeSlider slider)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            HomeSlider dbSlider = _db.HomeSliders.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (dbSlider == null) return RedirectToAction(nameof(Index));
            //if (!ModelState.IsValid) return View(dbSlider);
            if ( slider.Title ==null||slider.Description==null) return View( dbSlider);
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage()) return IsNonValid("Photo", "Please select image type!!!", dbSlider);
                if (slider.Photo.MaxSize(200)) return IsNonValid("Photo", "Select PHOTO max-size 200!", dbSlider);
                
                string folder = Path.Combine("assets", "img", "slider");
                string filename = await slider.Photo.SaveImageAsync(_env.WebRootPath, folder);
                
                
                int countSlider = _db.HomeSliders.Where(s => s.IsDeleted == false).Count();
                if (countSlider > 3)
                {
                    string oldPath = Path.Combine(_env.WebRootPath, folder, dbSlider.BgImage);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);

                    }
                }
                dbSlider.BgImage = filename;
            }
            dbSlider.Title = slider.Title;
            dbSlider.Description = slider.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #region My IsNonValid Metods
        public ActionResult IsNonValid(string errorName, string errorContent)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View();
        }
        public ActionResult IsNonValid(string errorName, string errorContent,object returnObj)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View(returnObj);
        }
        #endregion



    }
}
