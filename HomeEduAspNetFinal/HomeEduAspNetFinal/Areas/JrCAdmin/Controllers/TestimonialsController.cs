using Fiorello.Extensions;
using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
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
    public class TestimonialsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public TestimonialsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {

            int countTestimonial = _db.Testimonials.Count();
            ViewBag.Count = countTestimonial;
            return View(_db.Testimonials.ToList());
        }

        #region Create Testimonial
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {

            if (testimonial.Photo == null) return IsNonValid("", "Please select PHOTO!!!");
            if (!testimonial.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (testimonial.Photo.MaxSize(100)) return IsNonValid("", "Select PHOTO max-size 100!");
            string folder = Path.Combine("assets", "img", "testimonial");
            string filename = await testimonial.Photo.SaveImageAsync(_env.WebRootPath, folder);
            testimonial.Image = filename;

            await _db.Testimonials.AddAsync(testimonial);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Testimonial

        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Testimonial testimonial = _db.Testimonials.FirstOrDefault(c => c.Id == id);
            if (testimonial == null) return RedirectToAction(nameof(Index));

            return View(testimonial);
        }
        #endregion

        #region Delete Testimonial
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Testimonial testimonial = _db.Testimonials.FirstOrDefault(c => c.Id == id);
            if (testimonial == null) return RedirectToAction(nameof(Index));

            return View(testimonial);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Testimonial testimonial = _db.Testimonials.FirstOrDefault(c => c.Id == id);
            if (testimonial == null) return RedirectToAction(nameof(Index));

            int countTestimonial = _db.Testimonials.Count();

            if (countTestimonial > 1)
            {
                string folder = Path.Combine("assets", "img", "testimonial");
                string path = Path.Combine(_env.WebRootPath, folder, testimonial.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.Testimonials.Remove(testimonial);
            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Testimonial
        public IActionResult Update(int? id)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            Testimonial testimonial = _db.Testimonials.FirstOrDefault(c => c.Id == id);
            if (testimonial == null) return RedirectToAction(nameof(Index));

            return View(testimonial);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Testimonial testimonial)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            Testimonial dbTestimonial = _db.Testimonials.FirstOrDefault(c => c.Id == id);
            if (testimonial == null) return RedirectToAction(nameof(Index));

            if (testimonial.Photo != null)
            {

                if (!testimonial.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", dbTestimonial);
                if (testimonial.Photo.MaxSize(100)) return IsNonValid("", "Select PHOTO max-size 100!", dbTestimonial);

                string folder = Path.Combine("assets", "img", "testimonial");
                string filename = await testimonial.Photo.SaveImageAsync(_env.WebRootPath, folder);

                string path = Path.Combine(_env.WebRootPath, folder, dbTestimonial.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }

                dbTestimonial.Image = filename;
            }

            dbTestimonial.Person = testimonial.Person;
            dbTestimonial.Profession = testimonial.Profession;
            dbTestimonial.SayAboutUs = testimonial.SayAboutUs;
           
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
