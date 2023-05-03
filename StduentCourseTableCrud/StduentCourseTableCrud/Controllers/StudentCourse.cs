using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StduentCourseTableCrud.Data;
using StduentCourseTableCrud.Models;
using StduentCourseTableCrud.Models.Domain;

namespace StduentCourseTableCrud.Controllers
{
    public class StudentCourse : Controller
    {
        private readonly StudentCourseCRUD studentCourseCRUD;
        public StudentCourse(StudentCourseCRUD studentCourseCRUD)
        {
            this.studentCourseCRUD = studentCourseCRUD;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ViewModelInsert viewModelInsert)
        {
            var student = new Student();
            student.Student_Name = viewModelInsert.Student_Name;
            student.Student_Email = viewModelInsert.Student_Email;
            student.Student_Phone = viewModelInsert.Student_Phone;

            var course = new Course();
            course.Course_Name = viewModelInsert.Course_Name;

            var studentcourse = new StudetCourse()
            {
                Student = student,
                Course = course
            };  

            await studentCourseCRUD.Students.AddAsync(student);
            await studentCourseCRUD.Courses.AddAsync(course);
            await studentCourseCRUD.StudentCourse.AddAsync(studentcourse);
            await studentCourseCRUD.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Student> student = await studentCourseCRUD.Students.ToListAsync();            
            List<Course> course = await studentCourseCRUD.Courses.ToListAsync();
            List<StudetCourse> studentcourse = await studentCourseCRUD.StudentCourse.ToListAsync();

            return View(studentcourse);
        }
    }
}
