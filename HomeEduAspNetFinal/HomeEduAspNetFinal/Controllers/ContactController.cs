

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

        #region Message To Me
        public async Task<IActionResult> MessageToMe(string Email,string Subject,string Message)
        {
            if (Email != null ||( Subject != null && Message != null))
            {
                if (User.Identity.IsAuthenticated)
                {
                    AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                    MessageFromEmailToMe emailToMe = new MessageFromEmailToMe
                    {
                        Email = user.Email,
                        Messages = Message,
                        Subjects = Subject,
                    };
                    await _db.MessageFromEmailToMes.AddAsync(emailToMe);
                    await _db.SaveChangesAsync();
                    string bodyMes = $"{Message} from  {user.Email}";
                    SendEmail("kamranfn@code.edu.az",  Subject, bodyMes);
                    return Content("You send Message successfull !!!");

                }
                else
                {
                    MessageFromEmailToMe emailToMe = new MessageFromEmailToMe
                    {
                        Email = Email,
                        Messages = Message,
                        Subjects = Subject,
                    };
                    await _db.MessageFromEmailToMes.AddAsync(emailToMe);
                    await _db.SaveChangesAsync();
                    string bodyMes = $"{Message} from  {Email}";
                    SendEmail("kamranfn@code.edu.az",  Subject, bodyMes);
                    return Content("You send Message successfull !!!");
                }
            }
            return Content("Message don't send !!! ");
        }

        #endregion

        #region Send Email 
        public void SendEmail(string toMail, string subject, string mesBody)
        {
            string toEmail = toMail;
            SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("jrcomerun621@mail.ru", "lene1234");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("jrcomerun621@mail.ru", toEmail);
            message.Subject = subject;
            message.Body = mesBody;

            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            client.Send(message);

        }
        #endregion
        
    }
}
