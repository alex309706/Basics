using System;
using System.Linq;

namespace SetOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };
            //пересечение
            Console.WriteLine("Interesection:");
            var result = soft.Intersect(hard);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            //вычитание
            Console.WriteLine("Substraction:");
            result = soft.Except(hard);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            //объединение. Без дублирования
            Console.WriteLine("Union:");
            result = soft.Union(hard);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            //объединение. С дублированием
            Console.WriteLine("Concatination:");
            result = soft.Concat(hard);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }


        }
    }
}
