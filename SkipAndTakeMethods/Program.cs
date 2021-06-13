using System;
using System.Linq;

namespace SkipAndTakeMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int numbersToSkip = 3;
            Console.WriteLine($"Skipped {numbersToSkip} elements:");
            var elementsWithSkipping = numbers.Skip(3);
            foreach (var number in elementsWithSkipping)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            int numbersToTake = 3;
            Console.WriteLine($"Took {numbersToTake} elements:");
            var elementsToTake = numbers.Take(3);
            foreach (var number in elementsToTake)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var result = numbers.Skip(numbersToSkip).Take(numbersToTake);
            Console.WriteLine($"Skipped {numbersToSkip} and took {numbersToTake} elements:");
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            string[] teams = { "Bayern Munchen", "Borussia", "Real Madrid", "Manchester City", "PSG", "Bercalona" };
            Console.WriteLine("Teams:");
            foreach (var team in teams)
            {
                Console.Write(team + " ");
            }
            Console.WriteLine();


            var TeamsTakeWhileTeamStartWithB = teams.TakeWhile(team => team.StartsWith("B"));
            Console.WriteLine("Take while team starts with B:");
            foreach (var team in TeamsTakeWhileTeamStartWithB)
            {
                Console.Write(team + " ");
            }
            Console.WriteLine();

            var TeamsSkipWhileTeamStartWithB = teams.SkipWhile(team => team.StartsWith("B"));
            Console.WriteLine("Skip while team starts with B:");
            foreach (var team in TeamsSkipWhileTeamStartWithB)
            {
                Console.Write(team + " ");
            }
            Console.WriteLine();

        }
    }
}
