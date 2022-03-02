using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.API.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentAppDbContext db;

        public StudentRepo(StudentAppDbContext db)
        {
            this.db = db;
        }

        public string AddStudent(StudentDetail student)
        {
            this.db.StudentDetails.Add(student);
            this.db.SaveChanges();

            return "Student Added Successfully.....!";
        }

        public List<StudentDetail> GetAllStudents()
        {
            return this.db.StudentDetails.ToList();
        }
    }
}
