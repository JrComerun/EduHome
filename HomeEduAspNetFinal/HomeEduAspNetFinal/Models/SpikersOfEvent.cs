using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class SpikersOfEvent
    {
        public int Id { get; set; }
        [Required,MaxLength(35)]
        public string FullName { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int DetailOfEventId { get; set; }
        public DetailOfEvent DetailOfEvent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
