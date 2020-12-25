using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public CourseViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(int? take)
        {
           
            if (take == null)
            {
                List<Course> courses = _db.Courses.OrderByDescending(c => c.Id).ToList();
                return View(await Task.FromResult(courses));
            }
            else
            {
                List<Course> courses = _db.Courses.OrderByDescending(c => c.Id).Take((int)take).ToList();
                return View(await Task.FromResult(courses));
            }
            

        }
    }
}
