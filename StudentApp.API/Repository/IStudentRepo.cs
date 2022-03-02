using StudentApp.Core;

namespace StudentApp.API.Repository
{
    public interface IStudentRepo
    {
        List<StudentDetail> GetAllStudents();

        string AddStudent(StudentDetail student);
    }
}
