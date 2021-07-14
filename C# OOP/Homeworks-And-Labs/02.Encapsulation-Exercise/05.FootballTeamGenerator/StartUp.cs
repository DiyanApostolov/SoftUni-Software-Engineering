namespace _05.FootballTeamGenerator
{
    using System;
    using Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
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

                        this.teams.Add(team);
                    }
                    else if (command[0] == "Add")
                    {
                        this.ValidateTeamName(teamName);

                        var player = this.CreatePlayer(command);
                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

                        team.AddPlayer(player);
                    }
                    else if (command[0] == "Remove")
                    {
                        this.ValidateTeamName(teamName);

                        var playerName = command.Arguments[1];

                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

                        team.RemovePlayer(playerName);
                    }
                    else if (command[0] == "Rating")
                    {
                        this.ValidateTeamName(teamName);

                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

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
    }
    }
}
