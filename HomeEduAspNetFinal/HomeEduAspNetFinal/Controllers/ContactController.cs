

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
        public IActionResult Index()
        {
            return View();
        }


        //public IActionResult SendEmailToUser()
        //{
        //    MailMessage mail = new MailMessage();
        //    SmtpClient SmtpServer = new SmtpClient("smtp@gmail.com");

        //    mail.From = new MailAddress("knjc621@gmail.com");
        //    mail.To.Add("kami621@mail.ru");
        //    mail.Subject = "Notifications";
        //    mail.Body = "alindi";
        //    mail.IsBodyHtml = true;
        //    SmtpServer.Port = 587;
        //    SmtpServer.Credentials = new System.Net.NetworkCredential("knjc621@gmail.com", "lene1234");
        //    SmtpServer.EnableSsl = true;

        //    try
        //    {
        //        SmtpServer.Send(mail);
        //        return Content("alindi");
        //    }
        //    catch (Exception ex)
        //    {

        //        return Content("alindinmadi");
        //    }
           
        //}
    }
}
