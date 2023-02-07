using Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using ProjectCollege.Models;

namespace Project.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? Class{ get; set; }
    }
}
