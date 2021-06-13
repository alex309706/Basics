using Grouping.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>
        {
            new Phone {Name="Lumia 430", Company="Microsoft" },
            new Phone {Name="Mi 5", Company="Xiaomi" },
            new Phone {Name="LG G 3", Company="LG" },
            new Phone {Name="iPhone 5", Company="Apple" },
            new Phone {Name="Lumia 930", Company="Microsoft" },
            new Phone {Name="iPhone 6", Company="Apple" },
            new Phone {Name="Lumia 630", Company="Microsoft" },
            new Phone {Name="LG G 4", Company="LG" }
        };
            var groupedResult = phones.GroupBy(phone => phone.Company);
            foreach (IGrouping<string, Phone> group in groupedResult)
            {
                Console.WriteLine(group.Key);
                foreach (var phone in group)
                {
                    Console.WriteLine(phone.Name);
                }
            }

            var groupByQuery = from phone in phones
                               group phone by phone.Company into groupedElements
                               select new { NameOfCompany = groupedElements.Key, count=groupedElements.Count() };
            Console.WriteLine("By query:");
            foreach (var group in groupByQuery)
            {
                Console.WriteLine($"Name of company : {group.NameOfCompany} Count of devices : {group.count}");
            }


            var groupedByExtensionMethod = phones.GroupBy(phone => phone.Company).Select(group => new { NameOfCompany = group.Key, count = group.Count() });
            Console.WriteLine("By extensions method:");
            foreach (var group in groupedByExtensionMethod)
            {
                Console.WriteLine($"Name of company : {group.NameOfCompany} Count of devices : {group.count}");
            }
        }
    }
}
