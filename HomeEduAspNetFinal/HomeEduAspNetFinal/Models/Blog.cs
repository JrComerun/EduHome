using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [ Required,MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public DetailsOfBlog DetailsOfBlog { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
       
    }
}
