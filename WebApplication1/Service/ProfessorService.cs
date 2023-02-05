using Project;
using Project.Models;

namespace ProjectCollege.Service
{
    public class ProfessorService : IProfessorService
    {
        private readonly CollegeDbContext _context;

        public ProfessorService(CollegeDbContext context)
        {
            _context = context;
        }
        public void HandleAddProfessorRequest(Professor p)
        {
            AddProfessorToDB(p);
            AddProfessorToEmailService();
            throw new NotImplementedException();
        }
        private async void AddProfessorToDB(Professor p) {
            _context.Professors.Add(p);
            await _context.SaveChangesAsync();
        }
        private void AddProfessorToEmailService() { }
    }
}
