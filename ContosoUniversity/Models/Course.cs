using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
//tinfo200:[2021-03-13-jmc64-dykstra1]-This helps generate the the database and similar to gpa and the names there are getters and setters since information like courseID will get passed around in the program
namespace ContosoUniversity.Models
{
    public class Course
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
