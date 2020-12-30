﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }

        [Required]
        public string Descriptioon { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime NoticeDate { get; set; }
    }
}
