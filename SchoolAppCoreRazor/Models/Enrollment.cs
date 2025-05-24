using System;
using System.Collections.Generic;

namespace SchoolAppCoreRazor.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }  // Nullable in case a grade hasn't been assigned yet

        public Course Courses { get; set; }
        public Student Students { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}