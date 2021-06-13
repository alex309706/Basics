using System;
using System.Linq;

namespace AggregateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = new int[]  {1,2,3,4,5 };

            var result = collection.Aggregate((x,y) => x+y);
            Console.WriteLine("Aggregate sum.");
            Console.WriteLine(result);


            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            result = numbers.Where(number => number >= 10 && number %2 ==0).Count();
            Console.WriteLine("Count of even numbers that greater than 10. ");
            Console.WriteLine(result);

            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            result = numbers.Sum();
            Console.WriteLine($"Sum = {result}");

            result = numbers.Max();
            Console.WriteLine($"Maximum = {result}");

        
            result = numbers.Min();
            Console.WriteLine($"Minimum = {result}");

            double average = numbers.Average();
            Console.WriteLine($"Average = {average}");

         



        }
    }
}
