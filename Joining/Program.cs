using Joining.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Joining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Bayern Munich", Country ="Germany" },
                new Team { Name = "Barcelona", Country ="Spain" }
            };

            List<Player> players = new List<Player>()
            {
                new Player {Name="Messi", Team="Barcelona"},
                new Player {Name="Neymar", Team="Barcelona"},
                new Player {Name="Robben", Team="Bayern Munich"}
            };

            var result = players.Join(teams,
                player=> player.Team,
                team=>team.Name,
                (player,team)=> new {Name=player.Name , Team = player.Team, Country = team.Country }
                );

            foreach (var player in result)
            {
                Console.WriteLine($"{player.Name} plays in {player.Team} from {player.Country}");
            }
        }
    }
}
