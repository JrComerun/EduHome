using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class DetailOfCourse
    {
        public int Id { get; set; }
        public string AboutCourse { get; set; } 
        public string HowToApply { get; set; }
        public string Certification { get; set; }
        public string Starts { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string Language { get; set; }
        public int Students { get; set; }
        public string Assesments { get; set; }
        public int Price { get; set; }
    }
}
