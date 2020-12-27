using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public   IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            DetailOfCourse detail = _db.DetailOfCourses.Include(d => d.Course).FirstOrDefault(c=>c.CourseId==id);
            if (detail == null) return NotFound();
            return View(detail);
        }
        public IActionResult Search(string search)
        {
            List<Course> model = _db.Courses.Where(p => p.Name.Contains(search)).Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_CourseSPartial", model);
        }
    }
}
