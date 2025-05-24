using System;
using System.Collections.Generic;

namespace SchoolAppCoreRazor.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }

        // One instructor can teach many courses
        public ICollection<Course>? Courses { get; set; }
    }
}