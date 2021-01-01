using System;
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
        [Required,MaxLength(500)]
        public string Decscription { get; set; }
        
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
        public ICollection<SpikersOfEvent> SpikersOfEvents { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
