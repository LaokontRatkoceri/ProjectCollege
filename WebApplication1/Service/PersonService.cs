using Project.Models;
using ProjectCollege.Models;

namespace ProjectCollege.Service
{
    public class PersonService
    {
        static Dictionary<string, Person> personData = new Dictionary<string, Person>()
        {
            {"Professor", new Professor() },
            {"Student", new Student() },
            {"Staff", new Staff() }
        };
        public static Person GetPerson(string type) {
            Person person = personData[type];  

            return person;
        }
    }
}
