using Project.Models;
using Project;

namespace ProjectCollege.Service
{
    public class FeeService: IFeeService
    {
        private readonly CollegeDbContext _context;

        public FeeService(CollegeDbContext context)
        {
            _context = context;
        }

        public void HandleAddFeeRequest(Fee f)
        {
            AddFeeToDB(f);
            AddFeeToEmailService();
            throw new NotImplementedException();
        }
        private async void AddFeeToDB(Fee f)
        {
            _context.Fees.Add(p);
            await _context.SaveChangesAsync();
        }
        private void AddFeeToEmailService() { }
    }
}
