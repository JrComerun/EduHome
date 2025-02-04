﻿using HomeEduAspNetFinal.Extensions;
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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.Teachers.Where(s => s.IsDeleted == false).Count() / 4);
            ViewBag.Page = page;
            int countTeachers = _db.Teachers.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countTeachers;
            return View(_db.Teachers.Where(t => t.IsDeleted == false).Include(t => t.ProfessionOfTeacher).Include(t => t.SocMedOfTeachers).OrderByDescending(d => d.Id).Skip(((int)page - 1) * 4).Take(4).ToList());
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
            TeacherVM teacher = new TeacherVM
            {
                ProfessionOfTeachers = _db.ProfessionOfTeacher.Where(e => e.IsDeleted == false).ToList(),
            };

            if (ProfId == null) return IsNonValid("", "Please select which of event!!", teacher);
            if (teacherVM.Teacher.Photo==null) return IsNonValid("", "Please select Photo!!!", teacher);
            if (!teacherVM.Teacher.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", teacher);
            if (teacherVM.Teacher.Photo.MaxSize(180)) return IsNonValid("", "Select PHOTO max-size 180!", teacher);
            bool isExist = _db.Teachers.Where(c => c.IsDeleted == false).
                Any(c => c.FullName.ToLower() == teacherVM.Teacher.FullName.ToLower());
            if (isExist) return IsNonValid("", "This spiker is already exist", teacher);
            #region Skill Value
            if (!(teacherVM.Teacher.DetailOfTeacher.ComunicationValue > 0 && teacherVM.Teacher.DetailOfTeacher.ComunicationValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.DesignValue > 0 && teacherVM.Teacher.DetailOfTeacher.DesignValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.DevelopmentValue > 0 && teacherVM.Teacher.DetailOfTeacher.DevelopmentValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.InnovtionValue > 0 && teacherVM.Teacher.DetailOfTeacher.InnovtionValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.LanguageValue > 0 && teacherVM.Teacher.DetailOfTeacher.LanguageValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.TeamLeaderValue > 0 && teacherVM.Teacher.DetailOfTeacher.TeamLeaderValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            #endregion
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

        #region Detail Teacher
        public IActionResult Detail(int? id)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            Teacher teacher = _db.Teachers.Where(c => c.IsDeleted == false).Include(c => c.DetailOfTeacher).
                Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).FirstOrDefault(c => c.Id == id);

            if (teacher == null) return RedirectToAction(nameof(Index));

            return View(teacher);
        }
        #endregion

        #region Delete Post
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Teacher teacher = _db.Teachers.Where(c => c.IsDeleted == false).Include(c => c.DetailOfTeacher).
                Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).FirstOrDefault(c => c.Id == id);
            if (teacher == null) return RedirectToAction(nameof(Index));
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Teacher teacher = _db.Teachers.Where(c => c.IsDeleted == false).Include(c => c.DetailOfTeacher).
                Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).FirstOrDefault(c => c.Id == id);
            if (teacher == null) return RedirectToAction(nameof(Index));

            int countTeacher = _db.Teachers.Where(s => s.IsDeleted == false).Count();

            if (countTeacher > 50)
            {
                string folder = Path.Combine("assets", "img", "teacher");
                string path = Path.Combine(_env.WebRootPath, folder, teacher.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.Teachers.Remove(teacher);
                foreach (SocMedOfTeacher s in teacher.SocMedOfTeachers)
                {
                    s.IsDeleted = true;
                    s.DeletedTime = DateTime.UtcNow;
                    _db.SocMedOfTeachers.Remove(s);
                }
            }
            else if (countTeacher > 3 && countTeacher <= 50)
            {
                teacher.IsDeleted = true;
                teacher.DeletedTime = DateTime.UtcNow;
                teacher.DetailOfTeacher.IsDeleted = true;
                teacher.DetailOfTeacher.DeletedTime = DateTime.UtcNow;
               
                foreach (SocMedOfTeacher s in teacher.SocMedOfTeachers)
                {
                    s.IsDeleted = true;
                    s.DeletedTime = DateTime.UtcNow;
                }

            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Teacher
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM teacherVM = new TeacherVM
            {
                Teacher = _db.Teachers.Where(c => c.IsDeleted == false).Include(c => c.DetailOfTeacher).
                Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).FirstOrDefault(c => c.Id == id),
                ProfessionOfTeachers = _db.ProfessionOfTeacher.Where(e => e.IsDeleted == false).Include(p => p.Teachers).ToList(),
            };

            if (teacherVM.Teacher == null) return RedirectToAction(nameof(Index));

            return View(teacherVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TeacherVM teacherVM, int? ProfId)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            TeacherVM dbteacherVM = new TeacherVM
            {
                Teacher = _db.Teachers.Where(c => c.IsDeleted == false).Include(c => c.DetailOfTeacher).
                Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).FirstOrDefault(c => c.Id == id),
                ProfessionOfTeachers = _db.ProfessionOfTeacher.Where(e => e.IsDeleted == false).Include(p => p.Teachers).ToList(),
               
            };
            bool isExist = _db.Teachers.Where(c => c.IsDeleted == false)
               .Any(c => c.FullName.ToLower() == teacherVM.Teacher.FullName.ToLower() && c.Id != id);

            if (isExist) return IsNonValid("", "This Teacher is already exist", dbteacherVM);
            if (teacherVM.Teacher == null) return RedirectToAction(nameof(Index));
            #region Skill Value
            if (!(teacherVM.Teacher.DetailOfTeacher.ComunicationValue > 0 && teacherVM.Teacher.DetailOfTeacher.ComunicationValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.DesignValue > 0 && teacherVM.Teacher.DetailOfTeacher.DesignValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.DevelopmentValue > 0 && teacherVM.Teacher.DetailOfTeacher.DevelopmentValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.InnovtionValue > 0 && teacherVM.Teacher.DetailOfTeacher.InnovtionValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.LanguageValue > 0 && teacherVM.Teacher.DetailOfTeacher.LanguageValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            if (!(teacherVM.Teacher.DetailOfTeacher.TeamLeaderValue > 0 && teacherVM.Teacher.DetailOfTeacher.TeamLeaderValue < 100))
            {
                return Content("yaxwi olacaq");
            }
            #endregion
            if (teacherVM.Teacher.Photo != null)
            {

                if (!teacherVM.Teacher.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", dbteacherVM);
                if (teacherVM.Teacher.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!", dbteacherVM);

                string folder = Path.Combine("assets", "img", "teacher");
                string filename = await teacherVM.Teacher.Photo.SaveImageAsync(_env.WebRootPath, folder);


                int countSpiker = _db.SpikersOfEvents.Where(s => s.IsDeleted == false).Count();
                if (countSpiker > 50)
                {
                    string path = Path.Combine(_env.WebRootPath, folder, dbteacherVM.Teacher.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);

                    }

                }
                dbteacherVM.Teacher.Image = filename;
            }
           
            dbteacherVM.Teacher.FullName = teacherVM.Teacher.FullName;
            dbteacherVM.Teacher.DetailOfTeacher.AboutMe = teacherVM.Teacher.DetailOfTeacher.AboutMe;
            dbteacherVM.Teacher.DetailOfTeacher.Degree = teacherVM.Teacher.DetailOfTeacher.Degree;
            dbteacherVM.Teacher.DetailOfTeacher.Hobbies = teacherVM.Teacher.DetailOfTeacher.Hobbies;
            dbteacherVM.Teacher.DetailOfTeacher.Faculty = teacherVM.Teacher.DetailOfTeacher.Faculty;
            dbteacherVM.Teacher.DetailOfTeacher.MakeACall = teacherVM.Teacher.DetailOfTeacher.MakeACall;
            dbteacherVM.Teacher.DetailOfTeacher.MailMe = teacherVM.Teacher.DetailOfTeacher.MailMe;
            dbteacherVM.Teacher.DetailOfTeacher.Skype = teacherVM.Teacher.DetailOfTeacher.Skype;
            dbteacherVM.Teacher.DetailOfTeacher.ComunicationValue = teacherVM.Teacher.DetailOfTeacher.ComunicationValue;
            dbteacherVM.Teacher.DetailOfTeacher.DesignValue = teacherVM.Teacher.DetailOfTeacher.DesignValue;
            dbteacherVM.Teacher.DetailOfTeacher.DevelopmentValue = teacherVM.Teacher.DetailOfTeacher.DevelopmentValue;
            dbteacherVM.Teacher.DetailOfTeacher.InnovtionValue = teacherVM.Teacher.DetailOfTeacher.InnovtionValue;
            dbteacherVM.Teacher.DetailOfTeacher.LanguageValue = teacherVM.Teacher.DetailOfTeacher.LanguageValue;
            dbteacherVM.Teacher.DetailOfTeacher.TeamLeaderValue = teacherVM.Teacher.DetailOfTeacher.TeamLeaderValue;

            dbteacherVM.Teacher.ProfessionOfTeacherId = (int)ProfId;
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
