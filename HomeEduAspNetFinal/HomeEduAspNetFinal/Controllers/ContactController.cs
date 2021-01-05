

using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;
        public ContactController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Add Email Subcribe
        public async Task<IActionResult> AddSubscribe(string Email)
        {
            bool IsExist = _db.SubScribes.Any(s => s.Email.ToLower().Trim() == Email.ToLower().Trim());
            if (!User.Identity.IsAuthenticated)
            {
                
                    if (!IsExist)
                    {
                        SubScribe subScribe = new SubScribe
                        {
                            Email = Email,
                        };
                        await _db.SubScribes.AddAsync(subScribe);
                        await _db.SaveChangesAsync();
                        return Content("You are subcribe successfull !!!");
                    }

                    else
                    {
                        return Content("You are already subcribe !!!");
                    }
                
                 
            }
            else
            {
                return Content(" You are already subcribe . When you sign up you are subscribe!!!");
            }

        }
        #endregion

    }
}
