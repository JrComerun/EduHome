using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using HomeEduAspNetFinal.ViewModels;
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
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            TempData["Id"] = id;
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
            int? id = (int)TempData["Id"];
            if (id == null) return NotFound();
            Comment comment = new Comment
            {

                UserName = username,
                Email = email,
                Subject = subject,
                Message = message,
                EventId = id,
            };
            if (comment == null) return NotFound();

            await _db.Comments.AddAsync(comment);
            await _db.SaveChangesAsync();
            return PartialView("_CommentsPartial", comment);
        }
        public IActionResult Search(string search)
        {
            List<Event> model = _db.Events.Where(p => p.Name.Contains(search)&&p.IsDeleted==false)
                .Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_EventSPartial", model);
        }
    }
}
