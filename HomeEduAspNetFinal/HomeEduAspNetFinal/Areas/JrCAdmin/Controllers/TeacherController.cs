using Fiorello.Extensions;
using HomeEduAspNetFinal.DAL;
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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            int countTeachers = _db.Teachers.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countTeachers;
            return View(_db.Teachers.Where(t=>t.IsDeleted==false).Include(t=>t.ProfessionOfTeacher).Include(t=>t.SocMedOfTeachers).ToList());
        }
        #region Create Teacher
        public IActionResult Create()
        {
            TeacherVM teacher = new TeacherVM
            {
                ProfessionOfTeachers = _db.ProfessionOfTeacher.Where(e => e.IsDeleted == false).ToList(),
            };
            return View(teacher); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherVM teacherVM, int? ProfId)
        {
            if (ProfId == null) return IsNonValid("", "Please select which of event!!");

            if (!teacherVM.Teacher.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (teacherVM.Teacher.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            bool isExist = _db.Teachers.Where(c => c.IsDeleted == false).
                Any(c => c.FullName.ToLower() == teacherVM.Teacher.FullName.ToLower());
            if (isExist) return IsNonValid("", "This spiker is already exist");
            string folder = Path.Combine("assets", "img", "teacher");
            string filename = await teacherVM.Teacher.Photo.SaveImageAsync(_env.WebRootPath, folder);
            teacherVM.Teacher.Image = filename;
            teacherVM.Teacher.IsDeleted = false;
            teacherVM.Teacher.ProfessionOfTeacherId = (int)ProfId;
            await _db.Teachers.AddAsync(teacherVM.Teacher);
            await _db.SaveChangesAsync();
            teacherVM.DetailOfTeacher.TeacherId = teacherVM.Teacher.Id;
            await _db.DetailOfTeachers.AddAsync(teacherVM.DetailOfTeacher);
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
