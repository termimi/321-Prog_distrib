using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace serealization
{
    public class Actor
    {
        public Actor(string firstName, string lastName, DateTime birthDate, string country, bool isAlive)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
            IsAlive = isAlive;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public bool IsAlive { get; set; }
        public string ToJson()
        {
            var jsonObject = JsonSerializer.Serialize(this);
            Console.WriteLine(jsonObject);
            File.WriteAllText($"./{this.FirstName}.json", jsonObject);
            return jsonObject;
        }
    }
}
