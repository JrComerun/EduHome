using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
        public string Venue { get; set; }
        public string Image { get; set; }
        public DetailOfEvent DetailOfEvent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
