﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class SkillOfTeacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
     
        public ICollection<DetailOfTeacher> DetailOfTeachers { get; set; }

    }
}
