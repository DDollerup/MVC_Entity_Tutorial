using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Entity_Tutorial.Models.Context
{
    public class CourseContext : DbContext
    {
        public CourseContext() : base("ConnectionString")
        {

        }
    }
}