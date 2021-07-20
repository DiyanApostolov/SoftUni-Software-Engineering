using _04.BorderControl.Contracts;

namespace _04.BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return $"{this.Id}";
        }
    }
}
