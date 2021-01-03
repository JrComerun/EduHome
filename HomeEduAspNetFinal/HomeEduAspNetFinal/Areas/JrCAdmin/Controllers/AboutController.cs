using HomeEduAspNetFinal.Extensions;
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
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.AboutArea.FirstOrDefault());
        }
        public IActionResult Update()
        {
            AboutArea area = _db.AboutArea.FirstOrDefault();
            return View(area);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(AboutArea area)
        {

            AboutArea dbArea = _db.AboutArea.FirstOrDefault();

            if (area.Photo != null)
            {

                if (!area.Photo.IsImage()) return IsNonValidd("", "Please select image type!!!", dbArea);
                if (area.Photo.MaxSize(300)) return IsNonValidd("", "Select PHOTO max-size 300!", dbArea);

                string folder = Path.Combine("assets", "img", "about");
                string filename = await area.Photo.SaveImageAsync(_env.WebRootPath, folder);

                string path = Path.Combine(_env.WebRootPath, folder, dbArea.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }

                dbArea.Image = filename;
            }
            dbArea.Title = area.Title;
            dbArea.Description = area.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #region My IsNonValid Metods
        public ActionResult IsNonValidd(string errorName, string errorContent)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View();
        }
        public ActionResult IsNonValidd(string errorName, string errorContent, object returnObj)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View(returnObj);
        }
        #endregion
    }
}
