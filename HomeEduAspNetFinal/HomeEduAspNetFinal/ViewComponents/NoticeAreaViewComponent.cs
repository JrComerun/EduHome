using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    public class NoticeAreaViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public NoticeAreaViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string paddingB)
        {
            ViewBag.PaddingB = paddingB;
            HomeVM homeVM = new HomeVM()
            {
                NoticeBoards = await _db.NoticeBoards.OrderByDescending(n => n.Id).Take(6).ToListAsync(),
                VideoTour = await _db.VideoTours.FirstOrDefaultAsync()
            };
            return View(await Task.FromResult(homeVM));
        }
    }
}
