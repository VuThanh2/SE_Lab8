using System.Collections.Generic;

namespace SchoolAppCoreRazor.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public Department Departments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}