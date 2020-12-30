using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index( int? blogCourseId, int? blogEventId, int? page = 1)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.Blogs.Count() / 6);
            ViewBag.Page = page;
            if (blogCourseId != null)
            {
                List<Blog> blogs = _db.Blogs.Where(c => c.IsDeleted == false && c.CourseId == blogCourseId).ToList();
                return View(blogs);
            }
            if ( blogEventId != null)
            {
                List<Blog> blogs = _db.Blogs.Where(c => c.IsDeleted == false && c.EventId== blogEventId).ToList();
                return View(blogs);
            }

            return View();
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            TempData["BlogId"] = id;
            CommentVM blogCommentVM = new CommentVM
            {
                DetailsOfBlog = _db.DetailsOfBlogs.Include(d => d.Blog).FirstOrDefault(c => c.BlogId == id),
                Comments = _db.Comments.Where(c => c.BlogId == id&&c.IsDeleted==false).ToList(),
            };
            if (blogCommentVM.DetailsOfBlog == null) return NotFound();
            return View(blogCommentVM);
        }
        
        public async Task<IActionResult> BlogComment(string username, string email, string subject, string message)
        {
            int id = (int)TempData["BlogId"];
            if ( username == null || email == null || subject == null || message == null) return NotFound();
        
                Comment comment = new Comment
                {
                    UserName = "Guest-" + username,
                    Email = email,
                    Subject = subject,
                    Message = message,
                    CreateTime = DateTime.UtcNow,
                    BlogId = id,
                };
                if (comment == null) return NotFound();
                await _db.Comments.AddAsync(comment);
                await _db.SaveChangesAsync();
                return PartialView("_CommentsPartial", comment);
           
        }
        public IActionResult Search(string search)
        {
            if (search == null) return NotFound();
            List<Blog> model = _db.Blogs.Where(p => p.Title.Contains(search)).Take(8).OrderByDescending(p => p.Id).ToList();

            return PartialView("_BolgSPartial", model);

        }

       
    }
}
