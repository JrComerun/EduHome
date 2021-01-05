using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
            //_userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await Task.FromResult(_db.Layout.FirstOrDefault()));
        }
    }
}
