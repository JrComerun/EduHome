using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewComponents
{
    public class TeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public TeacherViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(int? take)
        {

            if (take == null)
            {
                List<Teacher> teachers = _db.Teachers.Where(d => d.IsDeleted == false).Include(c=>c.SocMedOfTeachers).Include(c=>c.ProfessionOfTeacher).ToList();
                return View(await Task.FromResult(teachers));
            }
            else
            {
                List<Teacher> teachers = _db.Teachers.Include(c => c.SocMedOfTeachers).Include(c => c.ProfessionOfTeacher).Take((int)take).ToList();
                return View(await Task.FromResult(teachers));
            }


        }
    }
}
