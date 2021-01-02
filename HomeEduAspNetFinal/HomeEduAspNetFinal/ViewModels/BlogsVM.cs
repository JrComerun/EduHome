using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class BlogsVM
    {
        public Blog Blog { get; set; }
        public DetailsOfBlog DetailsOfBlog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }
        public List<Course> Courses { get; set; }
    }
}
