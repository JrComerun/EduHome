using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class DetailOfCourseViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public DetailOfCourseViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
