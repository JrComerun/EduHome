using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; }
        public DetailOfTeacher DetailOfTeacher { get; set; }
        public ProfessionOfTeacher ProfessionOfTeacher { get; set; }
        public SocMedOfTeacher SocMedOfTeacher { get; set; }
        public List<ProfessionOfTeacher> ProfessionOfTeachers { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<SocMedOfTeacher> SocMedOfTeachers { get; set; }
    }
}
