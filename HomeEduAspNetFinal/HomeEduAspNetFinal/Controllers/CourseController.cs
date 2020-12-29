using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
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
        public IActionResult Index(int blogCourseId)
        {
            List<Course> courses = _db.Courses.Where(c => c.IsDeleted == false && c.Id == blogCourseId).ToList();
            return View(courses);
        }
        public   IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            TempData["Id"] = id;
            CommentVM courseCommentVM = new CommentVM
            {
                DetailOfCourse = _db.DetailOfCourses.Where(d => d.IsDeleted == false).Include(d => d.Course).FirstOrDefault(c => c.CourseId == id),
                Comments = _db.Comments.Where(c => c.CourseId == id && c.IsDeleted == false).ToList(),
            };
            if (courseCommentVM.DetailOfCourse == null) return NotFound();
            return View(courseCommentVM);
        }
        public async Task<IActionResult> CourseComment(string username, string email, string subject, string message)
        {
            int id = (int)TempData["Id"];
            if (username==null||email==null||subject==null||message==null) return NotFound();
            Comment comment = new Comment
            {
                UserName = username,
                Email = email,
                Subject = subject,
                Message = message,
                CourseId = id,
            };
            if (comment == null) return NotFound();

            await _db.Comments.AddAsync(comment);
            await _db.SaveChangesAsync();
            return PartialView("_CommentsPartial", comment);
        }
        public IActionResult Search(string search)
        {
            List<Course> model = _db.Courses.Where(p => p.Name.Contains(search)&&p.IsDeleted==false).Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_CourseSPartial", model);
        }
    }
}
