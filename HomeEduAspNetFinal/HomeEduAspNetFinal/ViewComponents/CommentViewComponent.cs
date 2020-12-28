using HomeEduAspNetFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class CommentViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public CommentViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(string product)
        {
            ViewBag.Pro = product;
            return View();
        }
    }
}
