﻿using Fiorello.Extensions;
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
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public CourseController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            int countCourse = _db.Courses.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countCourse;
            return View(_db.Courses.Where(s => s.IsDeleted == false).Include(s => s.DetailOfCourse).ToList());
        }

        #region Create Course 
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DetailOfCourse detailOfCourse, Course course)
        {

            if (course.Photo == null) return IsNonValid("", "Please select PHOTO!!!");
            if (!course.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            if (course.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            bool isExist = _db.Courses.Where(c => c.IsDeleted == false).Any(c => c.Name.ToLower() == course.Name.ToLower());
            if (isExist) return IsNonValid("", "This Course is already exist");
            string folder = Path.Combine("assets", "img", "course");
            string filename = await course.Photo.SaveImageAsync(_env.WebRootPath, folder);
            course.Image = filename;
            course.IsDeleted = false;
            await _db.Courses.AddAsync(course);
            await _db.SaveChangesAsync();
            detailOfCourse.CourseId = course.Id;
            await _db.DetailOfCourses.AddAsync(detailOfCourse);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Course
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Course course = _db.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailOfCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return RedirectToAction(nameof(Index));

            return View(course);
        }
        #endregion

        #region Delete Course
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Course course = _db.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailOfCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return RedirectToAction(nameof(Index));

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Course course = _db.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailOfCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return RedirectToAction(nameof(Index));

            //if (course.Photo == null) return IsNonValid("", "Please select PHOTO!!!");
            //if (!course.Photo.IsImage()) return IsNonValid("", "Please select image type!!!");
            //if (course.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!");
            //bool isExist = _db.Courses.Where(c => c.IsDeleted == false).Any(c => c.Name.ToLower() == course.Name.ToLower());
            //if (isExist &&course== null) return IsNonValid("", "This Course is already exist");
            //string folder = Path.Combine("assets", "img", "course");
            //string filename = await course.Photo.SaveImageAsync(_env.WebRootPath, folder);
            //course.Image = filename;
            //course.IsDeleted = false;
            //await _db.Courses.AddAsync(course);
            //await _db.SaveChangesAsync();

            //await _db.SaveChangesAsync();
            int countCourse = _db.HomeSliders.Where(s => s.IsDeleted == false).Count();

            if (countCourse > 50)
            {
                string folder = Path.Combine("assets", "img", "course");
                string path = Path.Combine(_env.WebRootPath, folder, course.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.Courses.Remove(course);
            }
            else if (countCourse > 1 && countCourse <= 50)
            {
                course.IsDeleted = true;
                course.DeletedTime = DateTime.UtcNow;
                course.DetailOfCourse.IsDeleted = true;
                course.DetailOfCourse.DeletedTime = DateTime.UtcNow;
            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Course
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Course course = _db.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailOfCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return RedirectToAction(nameof(Index));

            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course)
        {
            
            if (id == null) return RedirectToAction(nameof(Index));
            Course dbCourse = _db.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailOfCourse).FirstOrDefault(c => c.Id == id);
            if (dbCourse == null) return RedirectToAction(nameof(Index));
            //if (!ModelState.IsValid) return NotFound();


            if (course.Photo != null)
            {
               
                if (!course.Photo.IsImage()) return IsNonValid("", "Please select image type!!!",dbCourse);
                if (course.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!",dbCourse);
               
                string folder = Path.Combine("assets", "img", "course");
                string filename = await course.Photo.SaveImageAsync(_env.WebRootPath, folder);
                

                int countCourse = _db.HomeSliders.Where(s => s.IsDeleted == false).Count();
                if (countCourse > 50)
                {
                    string path = Path.Combine(_env.WebRootPath, folder, dbCourse.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);

                    }
                    _db.Courses.Remove(dbCourse);
                }
                dbCourse.Image = filename;
            }
            bool isExist = _db.Courses.Where(c => c.IsDeleted == false)
                .Any(c => c.Name.ToLower() == course.Name.ToLower()&&c.Id!=course.Id);           

            
                if(isExist ) return IsNonValid("Name", "This Course is already exist", dbCourse);
                dbCourse.Name = course.Name;
                dbCourse.Description = course.Description;
                dbCourse.DetailOfCourse.AboutCourse = course.DetailOfCourse.AboutCourse;
                dbCourse.DetailOfCourse.HowToApply = course.DetailOfCourse.HowToApply;
                dbCourse.DetailOfCourse.Certification = course.DetailOfCourse.Certification;
                dbCourse.DetailOfCourse.Assesments = course.DetailOfCourse.Assesments;
                dbCourse.DetailOfCourse.ClassDuration = course.DetailOfCourse.ClassDuration;
                dbCourse.DetailOfCourse.Duration = course.DetailOfCourse.Duration;
                dbCourse.DetailOfCourse.StartDate = course.DetailOfCourse.StartDate;
                dbCourse.DetailOfCourse.Students = course.DetailOfCourse.Students;
                dbCourse.DetailOfCourse.Language = course.DetailOfCourse.Language;
                dbCourse.DetailOfCourse.Price = course.DetailOfCourse.Price;
                
           
               
            
            


            await _db.SaveChangesAsync();
            //return IsNonValid("", "This Course is already exist", dbCourse);
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
