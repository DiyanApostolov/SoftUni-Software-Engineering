using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> members { get; set; } = new List<Person>();

        public void Add(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(m => m.Age).FirstOrDefault();
        }
    }
}
