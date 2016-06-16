using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Entity_Tutorial.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int TeacherID { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
    }
}