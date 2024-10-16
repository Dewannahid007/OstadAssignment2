using OstadAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace OstadAssignment2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var course1= new Course { CourseId = 1 , CourseName="Bangla"};
            var course2 = new Course { CourseId = 2, CourseName = "English" };
            var Course3 = new Course { CourseId = 3, CourseName = "Computer Fundamental" };
            var Course4 = new Course { CourseId = 4, CourseName = "Data Stucture" };
            var Course5 = new Course { CourseId = 5, CourseName = "Algorithm" };
            var Course6 = new Course { CourseId = 6, CourseName = "Discreate Mathematics" };
            var Course7 = new Course { CourseId = 7, CourseName = "Data Communications" };
            var Course8 = new Course { CourseId = 8, CourseName = "Operating System" };
            var Course9 = new Course { CourseId = 9, CourseName = "Numerical Methods" };
            var Course10 = new Course { CourseId = 10, CourseName = "Computer Architecture" };
            var Course11 = new Course { CourseId = 11, CourseName = "DataBase Management System" };

           

            var teacher1 = new Teacher { TeacherId = 1, TeacherName = "Md Tajmul Islam Nahid" };
            var teacher2 = new Teacher { TeacherId = 2, TeacherName = "Yeamin Mondal" };
            var teacher3 = new Teacher { TeacherId = 3, TeacherName = "Ifthekhar Ahamed" };
            var teacher4 = new Teacher { TeacherId = 4, TeacherName = "Rayhan Kabir" };




            var Students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Arif", CourseName = course1, TeacherName = teacher1 },
                new Student { StudentId = 2, Name = "Sharif", CourseName = course2, TeacherName = teacher2 },
                new Student { StudentId = 3, Name = "Abid", CourseName = Course3, TeacherName = teacher2 },
                new Student { StudentId = 4, Name = "Sazzad", CourseName = Course4, TeacherName = teacher4 },
                new Student { StudentId = 5, Name = "Karim", CourseName = Course3, TeacherName = teacher2 },
                new Student { StudentId = 6, Name = "Shohel", CourseName = Course7, TeacherName = teacher3 },
                new Student { StudentId = 7, Name = "Rayhan", CourseName = Course6, TeacherName = teacher1 },
                new Student { StudentId = 8, Name = "Dipto", CourseName = Course8, TeacherName = teacher4 },
                new Student { StudentId = 9, Name = "Oly", CourseName = Course9, TeacherName = teacher3 },
                new Student { StudentId = 10, Name = "Lal Mia", CourseName = Course7, TeacherName = teacher1 }

            };

            return View(Students);
        }
    }
}