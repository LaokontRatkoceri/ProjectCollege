using Microsoft.EntityFrameworkCore;
using Project.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Keyless]

    public class staffCourse
    {
        public Staff staff{ get; set; }
        [ForeignKey("StaffId")]
        public int StaffId { get; set; }

        public Course course { get; set; }
        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
    }
}
