using System.ComponentModel.DataAnnotations;

namespace StduentCourseTableCrud.Models.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Course_Name { get; set; }

        public ICollection<StudetCourse> Enroll { get; set; }

    }
}
