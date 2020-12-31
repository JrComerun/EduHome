using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        public CourseController(AppDbContext db, SignInManager<AppUser> signInManager,
                                                 UserManager<AppUser> userManager)
        {
            _db = db;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index(int blogCourseId)
        {
            List<Course> courses = _db.Courses.Where(c => c.IsDeleted == false && c.Id == blogCourseId).ToList();
            return View(courses);
        }
        public IActionResult Detail(int? id)
        {
            int? courseId;
            if (id == null) return NotFound();
            courseId = id;
            TempData["CourseId"] = id;
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
            int id = (int)TempData["CourseId"];
            if (subject == null || message == null) return NotFound();

            Comment comment = new Comment();
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                comment.UserName = user.UserName;
                comment.Email = user.Email;
            }
            else
            {
                comment.UserName = "Guest-" + username;
                comment.Email = email;
            }

            comment.Subject = subject;
            comment.Message = message;
            comment.CreateTime = DateTime.UtcNow;
            comment.CourseId = id;

            if (comment == null) return NotFound();
            await _db.Comments.AddAsync(comment);
            await _db.SaveChangesAsync();
            return PartialView("_CommentsPartial", comment);



            //}
        }
        public IActionResult Search(string search)
        {
            if (search == null) return NotFound();
            List<Course> model = _db.Courses.Where(p => p.Name.Contains(search) && p.IsDeleted == false).Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_CourseSPartial", model);
        }
    }
}
