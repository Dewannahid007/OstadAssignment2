﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OstadAssignment2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}