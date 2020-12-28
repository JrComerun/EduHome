using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class EventVM
    {
        public DetailOfEvent DetailOfEvent { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
