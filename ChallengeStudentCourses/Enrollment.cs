﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Enrollment
    {
        public Course Course { get; set; }
        public Student student { get; set; }
        public int Grade { get; set; }

    }
}