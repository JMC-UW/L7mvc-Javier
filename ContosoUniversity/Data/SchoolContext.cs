using System;
using System.Collections.Generic;

using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

//tinfo200:[2021-03-13-jmc64-dykstra1]-The database context is created, this helps give the EF functionality and this also uses getter and setters as courses, enrollments, and students are entries/information that is changing and has to be referenced
namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }





        //tinfo200:[2021-03-13-jmc64-dykstra1]- this adds table appearance with the rows Course, Enrollment, and Student
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}