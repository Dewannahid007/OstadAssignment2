using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OstadAssignment2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int CourseId {  get; set; }
        public Course CourseName {  get; set; }

        public int TeacherId { get; set; }
        public Teacher TeacherName { get; set; }
    }
}