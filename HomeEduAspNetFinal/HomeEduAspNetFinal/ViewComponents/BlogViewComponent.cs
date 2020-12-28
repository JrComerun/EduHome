using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class BlogViewComponent  : ViewComponent
    { 

        private readonly AppDbContext _db;
        public BlogViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync( int? take, int col,int? skip)
        {
            ViewBag.Col = col;
            if (take==0)
            {
                List<Blog> blogs = _db.Blogs.Where(d => d.IsDeleted == false).OrderByDescending(c => c.Id).ToList();
                return View(await Task.FromResult(blogs));
            }
            else
            {
                if (skip==0 || skip == null)
                {
                    List<Blog> blogs = _db.Blogs.Where(d => d.IsDeleted == false).OrderByDescending(c => c.Id).Take((int)take).ToList();
                    return View(await Task.FromResult(blogs));
                }
                else
                {
                    List<Blog> blogs = _db.Blogs.Where(d => d.IsDeleted == false).OrderByDescending(c => c.Id)
                        .Skip((int)(skip - 1) * 6).Take((int)take).ToList();
                    return View(await Task.FromResult(blogs));
                }
            }


        }
    }
}
