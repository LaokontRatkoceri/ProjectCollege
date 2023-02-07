using ProjectCollege.Models;

namespace Project.Models
{
    public class Professor:Person
    {
        public int? ProfessorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses{ get; set; }
    }
}
