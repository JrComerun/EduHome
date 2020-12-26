using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class SectionTitleViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public SectionTitleViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(string title,string source)
        {
            ViewBag.SecTitle = title;
            ViewBag.Source = source;
            return View(await Task.FromResult(_db.SectionTitle.FirstOrDefault()));
        }
    }
}
