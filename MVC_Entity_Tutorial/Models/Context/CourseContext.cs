using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_Entity_Tutorial.Models;

namespace MVC_Entity_Tutorial.Models.Context
{
    public class CourseContext : DbContext
    {
        public CourseContext() : base("csCourses") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}