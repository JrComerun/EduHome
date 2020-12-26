using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class SpikersOfEvent
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Profession { get; set; }
        public string Image { get; set; }
        public int DetailOfEventId { get; set; }
        public DetailOfEvent DetailOfEvent { get; set; }
    }
}
