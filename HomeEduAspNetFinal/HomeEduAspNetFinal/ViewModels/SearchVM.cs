using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class SearchVM
    {
        public List<Teacher> Teachers { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
    }
}
