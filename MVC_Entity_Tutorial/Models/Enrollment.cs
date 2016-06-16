using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Entity_Tutorial.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public List<Student> EnrolledStudents = new List<Student>();
    }
}