﻿using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Extensions;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,
                                SignInManager<AppUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                AppDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }

            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "This account blocked!!!");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await _signInManager.PasswordSignInAsync(user, login.Password, true, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please,try few minutes later");
                return View(login);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }


            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return NotFound();
            AppUser newUser = new AppUser
            {
                UserName = register.UserName,
                Name = register.Name,
                SurName = register.SurName,
                Email = register.Email,

            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, Roles.Moderator.ToString());
            await _signInManager.SignInAsync(newUser, true);
            bool IsExist = _db.SubScribes.Any(c=>c.Email.ToLower().Trim()==newUser.Email.ToLower().Trim());
            // Add SubScribe for New Event
            if (!IsExist)
            {
                SubScribe subScribe = new SubScribe
                {
                    Email = newUser.Email,

                };

                await _db.SubScribes.AddAsync(subScribe);
                await _db.SaveChangesAsync();
            }
            
            return RedirectToAction("Index", "Home");
        
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #region CreateRoleManager

        //public async Task CreateUserRole()
        //{
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Admin.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Member.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Moderator.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Moderator.ToString() });
        //}
        #endregion
    }
}
