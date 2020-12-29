using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class LastsBlogViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public LastsBlogViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(string path)
        {
            ViewBag.Path = path;
            List<Blog> blogs = _db.Blogs.Where(b => b.IsDeleted == false).Include(b => b.Event).Include(b => b.Course).ToList();
             return View(await Task.FromResult(blogs));
        }
    }
}
