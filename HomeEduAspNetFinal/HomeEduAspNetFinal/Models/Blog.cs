using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public IFormFile Photo { get; set; }
        public DetailsOfBlog DetailsOfBlog { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public int? EventId { get; set; }
        public Event Event { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }


    }
}
