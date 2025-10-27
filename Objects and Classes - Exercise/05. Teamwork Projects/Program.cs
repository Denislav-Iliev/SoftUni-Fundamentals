using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int teamsToCreate = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

     
        for (int i = 0; i < teamsToCreate; i++)
        {
            string[] input = Console.ReadLine().Split("-");
            string creator = input[0];
            string teamName = input[1];

            bool nameTaken = teams.Any(t => t.TeamName == teamName);
            if (nameTaken)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            bool creatorTaken = teams.Any(t => t.Creator == creator);
            if (creatorTaken)
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            teams.Add(new Team(teamName, creator));
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] parts = command.Split("->");
            string user = parts[0];
            string teamName = parts[1];

            Team team = teams.FirstOrDefault(t => t.TeamName == teamName);
            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            bool userBusy = teams.Any(t => t.Creator == user || t.Members.Contains(user));
            if (userBusy)
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            team.Members.Add(user);
        }

        
        var validTeams = teams
            .Where(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.TeamName);

        var disbandTeams = teams
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.TeamName);

        foreach (var t in validTeams)
        {
            Console.WriteLine(t.TeamName);
            Console.WriteLine($"- {t.Creator}");
            foreach (var m in t.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {m}");
            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (var t in disbandTeams)
        {
            Console.WriteLine(t.TeamName);
        }
    }
}

class Team
{
    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string teamName, string creator)
    {
        TeamName = teamName;
        Creator = creator;
        Members = new List<string>();
    }
}