using Project;
using Project.Models;

namespace ProjectCollege.Service
{
    public class StudentService : IStudentService
    {
        private readonly CollegeDbContext _context;

        public StudentService(CollegeDbContext context)
        {
            _context = context;
        }
        public void HandleAddStudentRequest(Student s)
        {
            AddStudentToDB(s);
            AddStudentToEmailService();
            throw new NotImplementedException();
        }
        private async void AddStudentToDB(Student s)
        {
            _context.Students.Add(s);
            await _context.SaveChangesAsync();
        }
        private void AddStudentToEmailService() { }
    }
}
