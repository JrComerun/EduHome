using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class DetailsOfBlog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [ForeignKey("Bolg")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
