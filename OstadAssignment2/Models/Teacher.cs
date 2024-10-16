using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OstadAssignment2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }



        public ICollection<Student> Students { get; set; }
    }
}