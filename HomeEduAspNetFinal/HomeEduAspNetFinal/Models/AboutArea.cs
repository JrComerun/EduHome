using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class AboutArea
    {
        public int Id { get; set; }
        [Required,MaxLength(40)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
