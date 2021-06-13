using Joining.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ZipMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Bayern Munich", Country ="Germany" },
                new Team { Name = "Barcelona", Country ="Spain" },
                 new Team { Name = "Juventus", Country ="Italy" }
            };
            List<Player> players = new List<Player>()
            {
                new Player {Name="Messi", Team="Barcelona"},
                new Player {Name="Robben", Team="Bayern Munich"},
                new Player {Name="Buffon", Team="Juventus"}
            };
            var result = teams.Zip(players,
                (team,player)=>new 
                {
                    TeamName = team.Name,
                    Country = team.Country,
                    PlayerName = player.Name
                });
            foreach (var player in result)
            {
                Console.WriteLine($"Player : {player.PlayerName} Team: {player.TeamName} Country:  {player.Country}");
            }
        }
    }
}
