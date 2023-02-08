using Microsoft.EntityFrameworkCore;
using Project.Models;
using WebApplication1.Models;
using ProjectCollege.Models;
using ProjectCollege.helper;

namespace Project
{
    public class CollegeDbContext : DbContext
    {

        public CollegeDbContext (DbContextOptions options) : base(options) { }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        public DbSet<Semester> Semesters{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<staffCourse> staffCourses{ get; set; }
        public DbSet<StudentCourse> studentCourses{ get; set; }
        public DbSet<ProjectCollege.Models.User> User { get; set; } = default!;
    }
}
