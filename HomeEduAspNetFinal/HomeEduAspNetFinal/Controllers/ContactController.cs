

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


        //public async Task<IActionResult> SendEmailToUser()
        //{

        //    SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
        //    client.UseDefaultCredentials = false;
        //    client.EnableSsl = true;
        //    client.Credentials = new NetworkCredential("kami621@mail.ru", "lene1234");
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    MailMessage message = new MailMessage("kami621@mail.ru", "knjc621@gmail.com");
        //    message.Subject = "<By Default: IAP Choices Notification>";
        //    message.Body = "Hi, <Student_Name><br>Your choice for <Program Name> has been approved<br>";


        //    message.BodyEncoding = System.Text.Encoding.UTF8;
        //    message.IsBodyHtml = true;

        //    client.Send(message);
        //    return Content(message.Body);

        //}
       
    }
}
