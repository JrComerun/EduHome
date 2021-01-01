using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required,MaxLength(45)]
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DetailOfTeacher DetailOfTeacher { get; set; }
        public ICollection<SocMedOfTeacher> SocMedOfTeachers { get; set; }
        public int ProfessionOfTeacherId { get; set; }
        public ProfessionOfTeacher ProfessionOfTeacher { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
