using Project.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCollege.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public int? ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }

        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student{ get; set; }

    }
}
