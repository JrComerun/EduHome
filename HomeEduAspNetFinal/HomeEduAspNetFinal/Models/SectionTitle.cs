using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class SectionTitle
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
