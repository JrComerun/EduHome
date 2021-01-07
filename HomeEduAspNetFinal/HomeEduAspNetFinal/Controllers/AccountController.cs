using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Extensions;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
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
        #region Login
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
        #endregion

        #region Register
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
            bool IsExist = _db.SubScribes.Any(c => c.Email.ToLower().Trim() == newUser.Email.ToLower().Trim());
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

        #endregion

        #region Logout
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Reset Password
        public IActionResult ForEmailResetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForEmailResetPassword(EmailForResetPVM resetPVM)
        {
            if (resetPVM == null) return View();
            AppUser user = await _userManager.FindByEmailAsync(resetPVM.Email);
            if (user == null) return View();
            string url = "https://localhost:44366/Account/ResetPassword/" + $"{user.Id}";
            string subject = "Reset password in EduHome";
            string message = $"<a href='{url}'> Do You want reset password Click here</a>";
            SendEmail(user.Email, subject, message);
            return RedirectToAction("Login","Account");
        }
        public async Task<IActionResult> ResetPassword(string id)
        {
            
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string id,ResetPasswordVM reset)
        {
            
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (!ModelState.IsValid) return View(user);

            IdentityResult identityResult = await _userManager.ResetPasswordAsync(user, await _userManager.GeneratePasswordResetTokenAsync(user), reset.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            
            return RedirectToAction("Login");
        }
        #endregion

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

        #region Send Email 
        public void SendEmail(string toMail, string subject, string mesBody)
        {
            string toEmail = toMail;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("knjc621@gmail.com", "lene1234");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("knjc621@gmail.com", toEmail);
            message.Subject = subject;
            message.Body = mesBody;

            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            client.Send(message);

        }
        #endregion
    }
}
