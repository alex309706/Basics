using System.Linq;
using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] teams = { "Bavaria", "Borussia", "Real Madrid", "Manchester City", "PSG", "Barcelona" };

            //var selectedTeams = from t in teams
            //                    where t.ToUpper().StartsWith("B")
            //                    orderby t
            //                    select t;
            var selectedTeams = teams.Where(t=>t.ToUpper().StartsWith("B")).OrderBy(t=>t).Reverse();
            foreach (var team in selectedTeams)
            {
               Console.WriteLine(team);
            }
        }
    }
}
