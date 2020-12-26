using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class ProfessionOfTeacher
    {
        public int Id { get; set; }
        public string Profession { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
