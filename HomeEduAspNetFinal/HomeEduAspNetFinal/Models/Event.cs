using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required,MaxLength(60)]
        public string Name { get; set; }
        
        
        [Required]
        public string Venue { get; set; }
        [Required]
        public string Image { get; set; }
        public DetailOfEvent DetailOfEvent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public ICollection<SpikersOfEvent> SpikersOfEvents { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Comment> Comments { get; set; }
       
        [Required]
        public DateTime StartingTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }
}
