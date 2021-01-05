using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Extensions;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
    public class SocialMediaController : Controller
    {
        private readonly AppDbContext _db;
        public SocialMediaController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.Teachers.Where(s => s.IsDeleted == false).Count() / 4);
            ViewBag.Page = page;
            
            List<Teacher> teachers = _db.Teachers.Where(t => t.IsDeleted == false).Include(s => s.SocMedOfTeachers).
                OrderByDescending(d => d.Id).Skip(((int)page - 1) * 4).Take(4).ToList();

            return View(teachers);
        }

        #region Create Social
        public IActionResult Create()
        {
            TeacherVM teacherVM = new TeacherVM
            {

                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            return View(teacherVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherVM teacherVM, int? teacherId)
        {
            if (teacherId == null) return IsNonValid("", "Please select which of event!!");


            teacherVM.SocMedOfTeacher.IsDeleted = false;
            teacherVM.SocMedOfTeacher.TeacherId = (int)teacherId;
            await _db.SocMedOfTeachers.AddAsync(teacherVM.SocMedOfTeacher);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Social
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM teacherVM = new TeacherVM
            {
                SocMedOfTeacher = _db.SocMedOfTeachers.Where(s => s.IsDeleted == false).Include(c => c.Teacher).FirstOrDefault(s => s.Id == id),
                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            if (teacherVM.SocMedOfTeacher == null) return RedirectToAction(nameof(Index));
            return View(teacherVM);
        }
        #endregion

        #region Delete Social
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM teacherVM = new TeacherVM
            {
                SocMedOfTeacher = _db.SocMedOfTeachers.Where(s => s.IsDeleted == false).Include(c => c.Teacher).FirstOrDefault(s => s.Id == id),
                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            if (teacherVM.SocMedOfTeacher == null) return RedirectToAction(nameof(Index));
            return View(teacherVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM teacherVM = new TeacherVM
            {
                SocMedOfTeacher = _db.SocMedOfTeachers.Where(s => s.IsDeleted == false).Include(c => c.Teacher).FirstOrDefault(s => s.Id == id),
                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            if (teacherVM.SocMedOfTeacher == null) return RedirectToAction(nameof(Index));

            teacherVM.SocMedOfTeacher.IsDeleted = true;
            teacherVM.SocMedOfTeacher.DeletedTime = DateTime.UtcNow;



            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM teacherVM = new TeacherVM
            {
                SocMedOfTeacher = _db.SocMedOfTeachers.Where(s => s.IsDeleted == false).Include(c => c.Teacher).FirstOrDefault(s => s.Id == id),
                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            if (teacherVM.SocMedOfTeacher == null) return RedirectToAction(nameof(Index));
            return View(teacherVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TeacherVM teacherVM, int? teacherId)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM dbteacherVM = new TeacherVM
            {
                SocMedOfTeacher = _db.SocMedOfTeachers.Where(s => s.IsDeleted == false).Include(c => c.Teacher).FirstOrDefault(s => s.Id == id),
                Teachers = _db.Teachers.Where(e => e.IsDeleted == false).ToList(),
            };
            if (teacherVM.SocMedOfTeacher == null) return RedirectToAction(nameof(Index));

            dbteacherVM.SocMedOfTeacher.Link = teacherVM.SocMedOfTeacher.Link;
            dbteacherVM.SocMedOfTeacher.Icon = teacherVM.SocMedOfTeacher.Icon;
            dbteacherVM.SocMedOfTeacher.TeacherId = (int)teacherId;
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
