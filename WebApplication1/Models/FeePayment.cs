using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    [Keyless]
    public class FeePayment
    {
        public int FPaymentId { get; set; }
        public Fee fee { get; set; }
        [ForeignKey("FeeId")]
        public int FeeId { get; set; }
        public Student student { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set;}
        public string courseName { get; set; }
        public DateTime Date { get; set; }
    }
}
