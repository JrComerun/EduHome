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
    public class NoticeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public NoticeController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            int countNotice = _db.NoticeBoards.Count();
            ViewBag.Count = countNotice;
            return View(_db.NoticeBoards.ToList());
        }
        #region Create Notice
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NoticeBoard notice)
        {

            if (!ModelState.IsValid) return View();
            await _db.NoticeBoards.AddAsync(notice);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Detail Notice
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            NoticeBoard notice = _db.NoticeBoards.FirstOrDefault(n => n.Id == id);
            if (notice == null) return RedirectToAction(nameof(Index));
            return View(notice);
        }
        #endregion

        #region Delete Notice
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            NoticeBoard notice = _db.NoticeBoards.FirstOrDefault(n => n.Id == id);
            if (notice == null) return RedirectToAction(nameof(Index));
            return View(notice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            NoticeBoard notice = _db.NoticeBoards.FirstOrDefault(n => n.Id == id);
            if (notice == null) return RedirectToAction(nameof(Index));

            int countnotice = _db.NoticeBoards.Count();

            if (countnotice > 3)
            {

                _db.NoticeBoards.Remove(notice);
            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Notice
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            NoticeBoard notice = _db.NoticeBoards.FirstOrDefault(n => n.Id == id);
            if (notice == null) return RedirectToAction(nameof(Index));
            return View(notice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, NoticeBoard notice)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            NoticeBoard dbNotice = _db.NoticeBoards.FirstOrDefault(n => n.Id == id);
            if (notice == null) return RedirectToAction(nameof(Index));



            dbNotice.Descriptioon = notice.Descriptioon;
            dbNotice.NoticeDate = notice.NoticeDate;


            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            #endregion
        }
    }
}
