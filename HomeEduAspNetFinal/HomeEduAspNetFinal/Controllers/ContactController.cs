

using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{

    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Add Subcribe
        public async Task<IActionResult> AddSubscribe(string Email)
        {
            if (User.Identity.IsAuthenticated)
            {
                SubScribe subScribe = new SubScribe
                {
                    Email = Email,
                 
                };

                await _db.SubScribes.AddAsync(subScribe);
                await _db.SaveChangesAsync();
            }
            else
            {
                return Content("olmaz");
            }

            return RedirectToAction("Index", "Home");
        }
        #endregion

    }
}
