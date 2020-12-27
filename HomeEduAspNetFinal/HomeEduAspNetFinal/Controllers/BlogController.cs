﻿using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page = 1)
        {
           
            ViewBag.PageCount = Decimal.Ceiling((decimal)_db.Blogs.Count() / 6);
            ViewBag.Page = page;
            if (page == 0)
            {
                
                return View(_db.Blogs.Take(6).OrderByDescending(d => d.Id).ToList());
            }
            else
            {
                
                return View(_db.Blogs.Skip(((int)page - 1) * 6).Take(6).OrderByDescending(d => d.Id).ToList());
            }
            
        }
        
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            DetailsOfBlog detail = _db.DetailsOfBlogs.Include(d => d.Blog).FirstOrDefault(c => c.BlogId== id);
            if (detail == null) return NotFound();
            return View(detail);
        }
        public IActionResult Search(string search)
        {
            List<Blog> model = _db.Blogs.Where(p => p.Title.Contains(search)).Take(8).OrderByDescending(p => p.Id).ToList();

            return PartialView("_BolgSPartial", model);
           
        }
    }
}
