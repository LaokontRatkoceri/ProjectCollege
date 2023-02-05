using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Fee
    {
        public int FeeId { get; set; }
        

        public int SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public Semester semester { get; set; }
  
        public DateTime Date { get; set; }

    }
}
