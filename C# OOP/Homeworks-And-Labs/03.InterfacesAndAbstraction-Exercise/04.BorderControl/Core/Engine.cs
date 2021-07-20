namespace _04.BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _04.BorderControl.Contracts;
    using _04.BorderControl.Models;

    public class Engine
    {
        private readonly List<IIdentifiable> identifiables;

        public Engine()
        {
            this.identifiables = new List<IIdentifiable>();
        }

        public void Run()
        {
            try
            {
                string input = Console.ReadLine();

                while (input != "End")
                {
                    string[] tokens = input
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Length == 3)
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        string id = tokens[2];

                        IIdentifiable citizen = new Citizen(name, age, id);
                        this.identifiables.Add(citizen);
                    }
                    else if(tokens.Length == 2)
                    {
                        string name = tokens[0];
                        string id = tokens[1];

                        IIdentifiable robot = new Robot(name, id);
                        this.identifiables.Add(robot);
                    }

                    input = Console.ReadLine();
                }

                var fakeIdDigits = Console.ReadLine();

                foreach (var identifiable in identifiables.Where(i => i.Id.EndsWith(fakeIdDigits)))
                {
                    Console.WriteLine(identifiable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
