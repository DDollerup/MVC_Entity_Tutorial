using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Entity_Tutorial.Models.Context;
using MVC_Entity_Tutorial.Models;

namespace MVC_Entity_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        CourseContext context = new CourseContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teachers()
        {
            List<Teacher> teachers = context.Teachers.ToList();
            return View(teachers);
        }

        public ActionResult ShowTeacher(int id = 0)
        {
            Teacher teacher = context.Teachers.FirstOrDefault(x => x.ID == id);
            teacher.CoursesAssigned = context.Courses.Where(x => x.TeacherID == id).ToList();
            return View(teacher);
        }

        public ActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeacherSubmit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                context.Teachers.Add(teacher);
                context.SaveChanges(); 
            }
            return RedirectToAction("Teachers");
        }

        public ActionResult UpdateTeacher(int id = 0)
        {
            Teacher teacherToEdit = context.Teachers.FirstOrDefault(x => x.ID == id);
            return View(teacherToEdit);
        }

        [HttpPost]
        public ActionResult UpdateTeacherSubmit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                context.Teachers.Attach(teacher);
                context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

            return RedirectToAction("Teachers");
        }

        public ActionResult DeleteTeacherSubmit(int id)
        {
            Teacher teacherToDelete = context.Teachers.FirstOrDefault(x => x.ID == id);
            if (teacherToDelete != null && teacherToDelete.ID > 0)
            {
                context.Teachers.Remove(teacherToDelete);
                context.SaveChanges(); 
            }
            return Redirect("Teachers");
        }

        public ActionResult TeachersFirstnameAscending()
        {
            List<Teacher> teachersNameAsc = context.Teachers
                .SqlQuery("SELECT * FROM Teachers ORDER BY Firstname ASC").ToList();
            return View("Teachers", teachersNameAsc);
        }

        public ActionResult TeachersLastnameAscending()
        {
            List<Teacher> teachersNameAsc = context.Teachers
                .SqlQuery("SELECT * FROM Teachers ORDER BY Lastname ASC").ToList();
            return View("Teachers", teachersNameAsc);
        }
    }
}