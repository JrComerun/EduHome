using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.Models
{
    public class DetailOfTeacher
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string MailMe { get; set; }
        public string MakeACall { get; set; }
        public string Skype { get; set; }
        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int LanguageValue { get; set; }
        public int TeamLeaderValue { get; set; }
        public int DevelopmentValue { get; set; }
        public int DesignValue { get; set; }
        public int InnovtionValue { get; set; }
        public int ComunicationValue { get; set; }

    }
}
