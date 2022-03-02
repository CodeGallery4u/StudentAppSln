using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentAppDbContext db;

        public StudentController(StudentAppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(this.db.StudentDetails.ToList());
        }

        [HttpPost]
        public IActionResult SaveStudent(StudentDetail student)
        {
            this.db.StudentDetails.Add(student);
            this.db.SaveChanges();

            return Ok("Student Added Successfully.....!");
        }
    }
}
