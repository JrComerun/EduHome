﻿using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
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

            DetailOfTeacher detail = _db.DetailOfTeachers.Where(d => d.IsDeleted == false).Include(d => d.Teacher).ThenInclude(t => t.SocMedOfTeachers)
                .Include(t=>t.Teacher).ThenInclude(t=>t.ProfessionOfTeacher).FirstOrDefault(c => c.TeacherId == id);
            if (detail == null) return NotFound();
            return View(detail);
        }
        public IActionResult Search(string search)
        {
            if (search == null) return NotFound();
            List<Teacher> model = _db.Teachers.Where(d => d.IsDeleted == false).Include(t=>t.ProfessionOfTeacher).Include(t=>t.SocMedOfTeachers)
                .Where(p => p.FullName.Contains(search)).Take(8).OrderByDescending(p => p.Id).ToList();
            return PartialView("_TeacherSPartial", model);
        }
    }
}
