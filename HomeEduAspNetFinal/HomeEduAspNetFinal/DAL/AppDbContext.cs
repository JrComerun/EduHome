﻿using HomeEduAspNetFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<AboutArea> AboutAreas { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<DetailOfCourse> DetailOfCourses { get; set; }
    }
}
