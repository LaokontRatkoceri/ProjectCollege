using Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Project.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? Class{ get; set; }
    }
}
