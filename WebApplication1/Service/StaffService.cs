using Project;
using Project.Models;

namespace ProjectCollege.Service
{
    public class StaffService : IStaffService
    {
        private readonly CollegeDbContext _context;

        public StaffService(CollegeDbContext context)
        {
            _context = context;
        }
        public void HandleAddStaffRequest(Staff s)
        {
            AddStaffToDB(s);
            AddStaffToEmailService();
            throw new NotImplementedException();
        }
        private async void AddStaffToDB(Staff s)
        {
            _context.Staff.Add(s);
            await _context.SaveChangesAsync();
        }
        private void AddStaffToEmailService() { }
    }
}
