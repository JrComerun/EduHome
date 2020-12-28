using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class CourseVM
    {
        public DetailOfCourse DetailOfCourse { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
