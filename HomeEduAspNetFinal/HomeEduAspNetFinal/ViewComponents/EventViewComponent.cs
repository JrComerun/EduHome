﻿using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    
    public class EventViewComponent : ViewComponent
    {

        private readonly AppDbContext _db;
        public EventViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(int? take)
        {
            
            if (take==0)
            {
                List<Event> events = _db.Events.Where(d => d.IsDeleted == false).OrderByDescending(s=>s.Id).ToList();
                return View(await Task.FromResult(events));
            }
            else
            {
                List<Event> events = _db.Events.Where(d => d.IsDeleted == false).OrderByDescending(s => s.Id).Take((int)take).ToList();
                return View(await Task.FromResult(events));
            }
        }
    }
}
