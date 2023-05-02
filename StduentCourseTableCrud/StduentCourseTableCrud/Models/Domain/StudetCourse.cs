using System.ComponentModel.DataAnnotations;

namespace StduentCourseTableCrud.Models.Domain
{
    public class StudetCourse
    {

        [Key]
        public int StudentCourse_Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }


    }
}