﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class SocMedOfTeacher
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
