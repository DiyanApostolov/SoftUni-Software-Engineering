namespace _05.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                try
                {
                    string[] command = input
                        .Split(';', StringSplitOptions.RemoveEmptyEntries);
                    string teamName = command[1];

                    if (command[0] == "Team")
                    {
                        var team = new Team(teamName);

                        teams.Add(team);
                    }
                    else if (command[0] == "Add")
                    {
                        ValidateTeamName(teamName, teams);

                        var player = CreatePlayer(command);
                        var team = teams.FirstOrDefault(x => x.Name == teamName);

                        team.AddPlayer(player);
                    }
                    else if (command[0] == "Remove")
                    {
                        ValidateTeamName(teamName, teams);

                        var playerName = command[2];

                        var team = teams.FirstOrDefault(x => x.Name == teamName);

                        team.RemovePlayer(playerName);
                    }
                    else if (command[0] == "Rating")
                    {
                        ValidateTeamName(teamName, teams);

                        var team = teams.FirstOrDefault(x => x.Name == teamName);

                        Console.WriteLine(team);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }
        }

        private static Player CreatePlayer(string[] command)
        {
            var playerName = command[2];
            var stat = CreateStat(command);

            return new Player(playerName, stat);
        }

        private static Stat CreateStat(string[] command)
        {
            var endurance = int.Parse(command[3]);
            var sprint = int.Parse(command[4]);
            var dribble = int.Parse(command[5]);
            var passing = int.Parse(command[6]);
            var shooting = int.Parse(command[7]);

            return new Stat(endurance, sprint, dribble, passing, shooting);
        }

        private static void ValidateTeamName(string name, List<Team> teams)
        {
            var team = teams.FirstOrDefault(x => x.Name == name);

            if (team == null)
            {
                throw new ArgumentException($"Team {name} does not exist.");
            }
        }
    }
    
}
