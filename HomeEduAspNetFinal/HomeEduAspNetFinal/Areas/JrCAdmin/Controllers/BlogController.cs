using Fiorello.Extensions;
using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;

        }
        public IActionResult Index()
        {
            int countBlog = _db.Blogs.Where(s => s.IsDeleted == false).Count();
            ViewBag.Count = countBlog;
            return View(_db.Blogs.Where(s => s.IsDeleted == false).Include(s => s.DetailsOfBlog).Include(c => c.Course).Include(c => c.Event).ToList());
        }

        #region Create Blog 
        public IActionResult Create()
        {
            BlogsVM blogsVM = new BlogsVM
            {
                Events = _db.Events.Where(c => c.IsDeleted == false).ToList(),
                Courses = _db.Courses.Where(c => c.IsDeleted == false).ToList(),
            };
            return View(blogsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogsVM blogvm, int courseId, int eventId)
        {
            BlogsVM blogsVM = new BlogsVM
            {
                Events = _db.Events.Where(c => c.IsDeleted == false).ToList(),
                Courses = _db.Courses.Where(c => c.IsDeleted == false).ToList(),
            };
            if (blogvm.Blog.Photo == null) return IsNonValid("", "Please select PHOTO!!!", blogsVM);
            if (!blogvm.Blog.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", blogsVM);
            if (blogvm.Blog.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!", blogsVM);
            bool isExist = _db.Blogs.Where(c => c.IsDeleted == false).Any(c => c.Title.ToLower() == blogvm.Blog.Title.ToLower());
            if (isExist) return IsNonValid("", "This Blog is already exist", blogsVM);
            string folder = Path.Combine("assets", "img", "blog");
            string filename = await blogvm.Blog.Photo.SaveImageAsync(_env.WebRootPath, folder);
            blogvm.Blog.Image = filename;
            blogvm.Blog.IsDeleted = false;
            blogvm.Blog.CourseId = courseId;
            blogvm.Blog.EventId = eventId;
            await _db.Blogs.AddAsync(blogvm.Blog);
            await _db.SaveChangesAsync();
            blogvm.DetailsOfBlog.BlogId = blogvm.Blog.Id;
            await _db.DetailsOfBlogs.AddAsync(blogvm.DetailsOfBlog);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail Blog
        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Blog blog = _db.Blogs.Where(c => c.IsDeleted == false).Include(c => c.DetailsOfBlog)
                .Include(c => c.Course).Include(c => c.Event).FirstOrDefault(c => c.Id == id);
            if (blog == null) return RedirectToAction(nameof(Index));

            return View(blog);
        }
        #endregion

        #region Delete Blog
        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Blog blog = _db.Blogs.Where(c => c.IsDeleted == false).Include(c => c.DetailsOfBlog)
                .Include(c => c.Course).Include(c => c.Event).FirstOrDefault(c => c.Id == id);
            if (blog == null) return RedirectToAction(nameof(Index));

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            Blog blog = _db.Blogs.Where(c => c.IsDeleted == false).Include(c => c.DetailsOfBlog)
                .Include(c => c.Course).Include(c => c.Event).FirstOrDefault(c => c.Id == id);
            if (blog == null) return RedirectToAction(nameof(Index));

            int countBlog = _db.Blogs.Where(s => s.IsDeleted == false).Count();

            if (countBlog > 50)
            {
                string folder = Path.Combine("assets", "img", "Blog");
                string path = Path.Combine(_env.WebRootPath, folder, blog.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);

                }
                _db.Blogs.Remove(blog);
            }
            else if (countBlog > 3 && countBlog <= 50)
            {
                blog.IsDeleted = true;
                blog.DeletedTime = DateTime.UtcNow;
                _db.DetailsOfBlogs.Remove(blog.DetailsOfBlog);

            }
            else
            {
                return Content("Davay qaqaw bir abarotda yoxla sen bacararsan");
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Blog
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Index));
            BlogsVM blogsVM = new BlogsVM
            {
                Events = _db.Events.Where(c => c.IsDeleted == false).ToList(),
                Courses = _db.Courses.Where(c => c.IsDeleted == false).ToList(),
                Blog = _db.Blogs.Where(c => c.IsDeleted == false).Include(c => c.DetailsOfBlog).
                Include(c => c.Course).Include(c => c.Event).FirstOrDefault(c => c.Id == id),
               
            };

            if (blogsVM.Blog == null) return RedirectToAction(nameof(Index));

            return View(blogsVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BlogsVM blogVM,int courseId,int eventId)
        {

            if (id == null) return RedirectToAction(nameof(Index));
            BlogsVM dbBlogsVM = new BlogsVM
            {
                Events = _db.Events.Where(c => c.IsDeleted == false).ToList(),
                Courses = _db.Courses.Where(c => c.IsDeleted == false).ToList(),
                Blog = _db.Blogs.Where(c => c.IsDeleted == false).Include(c => c.DetailsOfBlog).
                Include(c => c.Course).Include(c => c.Event).FirstOrDefault(c => c.Id == id),
            };

            if (blogVM.Blog == null) return RedirectToAction(nameof(Index));

            if (blogVM.Blog.Photo != null)
            {

                if (!blogVM.Blog.Photo.IsImage()) return IsNonValid("", "Please select image type!!!", dbBlogsVM);
                if (blogVM.Blog.Photo.MaxSize(150)) return IsNonValid("", "Select PHOTO max-size 150!", dbBlogsVM);

                string folder = Path.Combine("assets", "img", "blog");
                string filename = await blogVM.Blog.Photo.SaveImageAsync(_env.WebRootPath, folder);


                int countBlog = _db.Blogs.Where(s => s.IsDeleted == false).Count();
                if (countBlog > 50)
                {
                    string path = Path.Combine(_env.WebRootPath, folder, blogVM.Blog.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);

                    }

                }
                dbBlogsVM.Blog.Image = filename;
            }
            bool isExist = _db.Blogs.Where(c => c.IsDeleted == false)
                .Any(c => c.Title.ToLower() == blogVM.Blog.Title.ToLower() && c.Id != id);


            if (isExist) return IsNonValid("", "This Blog is already exist", dbBlogsVM);
            dbBlogsVM.Blog.Title = blogVM.Blog.Title;
            dbBlogsVM.Blog.Author = blogVM.Blog.Author;
            dbBlogsVM.Blog.DateTime = blogVM.Blog.DateTime;
            dbBlogsVM.Blog.DetailsOfBlog.Description = blogVM.Blog.DetailsOfBlog.Description;
            dbBlogsVM.Blog.EventId = eventId;
            dbBlogsVM.Blog.CourseId = courseId;
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

