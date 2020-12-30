using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public EventController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            TempData["EventId"] = id;
            CommentVM eventCommentVM = new CommentVM
            {
                DetailOfEvent = _db.DetailOfEvents.Where(d => d.IsDeleted == false).Include(d => d.SpikersOfEvents).
                Include(d => d.Event).FirstOrDefault(c => c.EventId == id),
                Comments = _db.Comments.Where(c => c.EventId == id && c.IsDeleted == false).ToList(),
            };
            if (eventCommentVM.DetailOfEvent == null) return NotFound();
            return View(eventCommentVM);
        }
        public async Task<IActionResult> EventComment(string username, string email, string subject, string message)
        {
            int id = (int)TempData["EventId"];
            if ( username == null || email == null || subject == null || message == null) return NotFound();
           
            
                Comment comment = new Comment
                {
                    UserName = "Guest-" + username,
                    Email = email,
                    Subject = subject,
                    Message = message,
                    CreateTime = DateTime.UtcNow,
                    EventId = id,
                };
                if (comment == null) return NotFound();
                await _db.Comments.AddAsync(comment);
                await _db.SaveChangesAsync();
                return PartialView("_CommentsPartial", comment);
           
        }
        public IActionResult Search(string search)
        {
            if (search == null) return NotFound();
            List<Event> model = _db.Events.Where(p => p.Name.Contains(search)&&p.IsDeleted==false)
                .Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_EventSPartial", model);
        }
    }
}
