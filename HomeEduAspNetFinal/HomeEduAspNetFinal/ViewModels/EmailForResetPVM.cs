﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class EmailForResetPVM
    {
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}
