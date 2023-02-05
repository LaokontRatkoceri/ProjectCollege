using Project;
using Project.Models;

namespace ProjectCollege.Service
{
    public class CourseService : ICourseService
    {
        private readonly CollegeDbContext _context;

        public CourseService(CollegeDbContext context)
        {
            _context = context;
        }
        public void HandleAddCourseRequest(Course c)
        {
            AddCourseToDB(c);
            AddCourseToEmailService();
            throw new NotImplementedException();
        }
        private async void AddCourseToDB(Course c)
        {
            _context.Courses.Add(c);
            await _context.SaveChangesAsync();
        }
        private void AddCourseToEmailService(){}
    }
}
