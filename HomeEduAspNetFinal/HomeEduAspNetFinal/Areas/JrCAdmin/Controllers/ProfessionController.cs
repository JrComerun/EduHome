using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    [Authorize(Roles = "Admin")]
    public class ProfessionController : Controller
    {
        private readonly AppDbContext _db;
        public ProfessionController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.ProfessionOfTeacher.Where(s => s.IsDeleted == false).Count() / 2);
            ViewBag.Page = page;
            int countProfession = _db.ProfessionOfTeacher.Where(c => c.IsDeleted == false).Count();
            ViewBag.Count = countProfession;
            return View(_db.ProfessionOfTeacher.Where(c => c.IsDeleted == false).OrderByDescending(d => d.Id).Skip(((int)page - 1) * 2).Take(2).ToList());
        }
        #region Create Profession
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfessionOfTeacher profession1)
        {

            bool isExist = _db.ProfessionOfTeacher.Where(c => c.IsDeleted == false).Any(c => c.Profession.ToLower() == profession1.Profession.ToLower());
            if (isExist) return IsNonValid("", "This Profession is already exist");
            await _db.ProfessionOfTeacher.AddAsync(profession1);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Profession
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            ProfessionOfTeacher profession = _db.ProfessionOfTeacher.FirstOrDefault(n => n.Id == id);
            if (profession == null) return RedirectToAction(nameof(Index));
            return View(profession);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProfessionOfTeacher profession1)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            ProfessionOfTeacher dbProfession = _db.ProfessionOfTeacher.FirstOrDefault(n => n.Id == id);
            if (profession1 == null) return RedirectToAction(nameof(Index));

            bool isExist = _db.ProfessionOfTeacher.Where(c => c.IsDeleted == false).
                Any(c => c.Profession.ToLower() == profession1.Profession.ToLower()&&c.Id==id);
            if (isExist) return IsNonValid("", "This Profession is already exist");

            dbProfession.Profession = profession1.Profession;
           


            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region My IsNonValid Metods
        public  ActionResult IsNonValid(string errorName, string errorContent)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View();
        }
        public  ActionResult IsNonValid(string errorName, string errorContent, object returnObj)
        {
            ModelState.AddModelError(errorName, errorContent);
            return View(returnObj);
        }
        #endregion

    }

}