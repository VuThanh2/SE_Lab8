namespace SchoolAppCoreMVC.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }

}