using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public int? EventId { get; set; }
        public Event Event { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public int? BlogId { get; set; }
        public Blog Blog { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
