using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public Course course { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public string Faculty { get; set; }

    }
}
