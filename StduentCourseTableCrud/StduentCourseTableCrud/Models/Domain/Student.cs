using System.ComponentModel.DataAnnotations;

namespace StduentCourseTableCrud.Models.Domain
{
    public class Student
    {

        [Key]
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_Email { get; set; }
        public string Student_Phone { get; set; }
        public ICollection<StudetCourse> Enroll { get; set; }
    }
}
