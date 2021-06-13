using Joining.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GroupJoin
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
            var groupJoinResult = teams.GroupJoin(players,
                team=> team.Name,
                player => player.Team,
                (team,players)=> new 
                {
                    TeamName= team.Name,
                    Country = team.Country,
                    Players = players.Select(player =>player)
                });

            foreach (var group in groupJoinResult)
            {
                Console.WriteLine($"Team : {group.TeamName}  Country : {group.Country}");
                foreach (var  player in group.Players)
                {
                    Console.WriteLine($"Player : {player.Name}");
                }
            }

        }
    }
}
