using Microsoft.EntityFrameworkCore;
using StduentCourseTableCrud.Models.Domain;
using System.Collections.Generic;
using System.Data.Common;

namespace StduentCourseTableCrud.Data
{
    public class StudentCourseCRUD : DbContext

    {

        public StudentCourseCRUD(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudetCourse> StudentCourse { get; set; }
    }
}
