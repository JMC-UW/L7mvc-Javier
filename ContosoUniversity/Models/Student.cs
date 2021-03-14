using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//tinfo200:[2021-03-13-jmc64-dykstra1]- in this file the getters and setters are used for collected information it is also referenced in multiple files since this is information that is used and implemented that needs to be referenced for the entries to work
namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
