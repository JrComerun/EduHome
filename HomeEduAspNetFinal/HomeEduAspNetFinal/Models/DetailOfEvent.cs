﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class DetailOfEvent
    {
        public int Id { get; set; }
        [Required,MinLength(100),MaxLength(500)]
        public string Decscription { get; set; }
        
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
