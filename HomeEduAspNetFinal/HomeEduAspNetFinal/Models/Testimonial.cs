﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Person { get; set; }
        [Required, MaxLength(50)]
        public string Profession { get; set; }
        [Required, MaxLength(100)]
        public string SayAboutUs { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
