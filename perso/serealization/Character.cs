using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace serealization
{
    public class Character
    {
        public Character(string firstName, string lastName, string description,Actor? playedBy)
        {
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            PlayedBy = playedBy;
        }
        public Character()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Actor PlayedBy { get; set; }

        public string ToJson()
        {
            var jsonObject = JsonSerializer.Serialize(this);
            Console.WriteLine(jsonObject);
            File.WriteAllText($"./{this.FirstName}.json",jsonObject);
            return jsonObject;
        }
        public Character deserelizeJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Character deseralizedJson = JsonSerializer.Deserialize<Character>(json);
            return deseralizedJson;
        }
        public void ToString()
        {
             Console.WriteLine($"{this.FirstName},{this.LastName}");
        }
    }
}
