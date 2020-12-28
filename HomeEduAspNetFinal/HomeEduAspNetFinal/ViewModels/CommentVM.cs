using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class CommentVM
    {
        public DetailsOfBlog DetailsOfBlog { get; set; }
        public DetailOfCourse DetailOfCourse { get; set; }
        public DetailOfEvent DetailOfEvent { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
