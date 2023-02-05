namespace Project.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses{ get; set; }
    }
}
