namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-jmc64-dykstra1]- This is the grades similar to how first and lastnames are used the grades use getters and setters and it is apart of the entries therefore it needs to be referenced as well per entry
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Student Student { get; set; }


    }
}