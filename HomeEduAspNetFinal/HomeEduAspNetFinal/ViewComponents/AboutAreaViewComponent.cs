using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    public class AboutAreaViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public AboutAreaViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_db.AboutAreas.FirstOrDefault()));
        }
    }
}
