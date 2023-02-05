using Microsoft.EntityFrameworkCore;
using Project.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Keyless]
    public class StudentCourse
    {
        public Student student{ get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        public Course course{ get; set; }
        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
    }
}
