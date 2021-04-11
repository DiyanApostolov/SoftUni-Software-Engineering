using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            List<string> creators = new List<string>();

            for (int i = 0; i < numberOfTeams; i++)
            {         
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];

                Team newTeam = new Team(teamName, creator);

                bool isTeamExist = teamList.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teamList.Select(y => y.Creator).Contains(creator);
                
                if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                else
                {
                    creators.Add(creator);
                }

                if (isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    teamList.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] memberTeam = teamMembers.Split("->");
                string member = memberTeam[0];
                string team = memberTeam[1];

                bool isTeamExist = teamList.Select(x => x.TeamName).Contains(team);
                bool isCreatorExist = teamList.Select(x => x.Creator).Contains(member);
                bool isMemberExist = teamList.Select(x => x.Members).Any(x => x.Contains(member));

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else
                {
                    int index = teamList.FindIndex(x => x.TeamName == team);
                    teamList[index].Members.Add(member);               
                }

                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teamList.OrderBy(x => x.TeamName)
                                            .Where(x => x.Members.Count == 0)
                                            .ToArray();

            Team[] fullTeams = teamList.OrderByDescending(x => x.Members.Count)
                                       .ThenBy(x => x.TeamName)
                                       .Where(x => x.Members.Count > 0)
                                       .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeams)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }
            sb.AppendLine("Teams to disband:");
            foreach (Team team in teamsToDisband)
            {
                sb.AppendLine(team.TeamName);
            }

            Console.WriteLine(sb.ToString()); ;
        }        
    }

    public class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TeamName);
            sb.AppendLine($"- {Creator}");
            
            return sb.ToString().TrimEnd();
        }
    }
}
