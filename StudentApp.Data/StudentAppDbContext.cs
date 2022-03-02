using Microsoft.EntityFrameworkCore;
using StudentApp.Core;

namespace StudentApp.Data
{
    public class StudentAppDbContext: DbContext
    {
        public StudentAppDbContext(DbContextOptions<StudentAppDbContext> option): base(option)
        {

        }

        public DbSet<StudentDetail> StudentDetails { get; set; }

    }
}