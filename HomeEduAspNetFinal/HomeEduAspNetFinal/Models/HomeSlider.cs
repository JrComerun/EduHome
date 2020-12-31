using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }
        [Required, StringLength(40)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}
