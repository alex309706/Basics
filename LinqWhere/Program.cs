using LinqWhere.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<User> users = new List<User>
            //{
            //    new User {Name="Tom", Age=23, Languages = new List<string> { "English", "Deuch" }},
            //    new User {Name="Bob", Age=27, Languages = new List<string> { "English", "France" }},
            //    new User {Name="John", Age=29, Languages = new List<string> {"English", "Spanish" }},
            //    new User {Name="Alice", Age=24, Languages = new List<string> {"Spanish", "Deuch" }}
            //};
            //var sortedByAge = users.Where(u=>u.Age>24);
            //foreach (User u in sortedByAge)
            //{
            //    Console.WriteLine($"Name: {u.Name} Age :{u.Age}");
            //}
            //var complexQuery = users.SelectMany(u => u.Languages,
            //    (u, l) => new { User = u, Languages = l })
            //    .Where(u => u.Languages == "English" && u.User.Age>25);

            //foreach (var u in complexQuery)
            //{
            //    u.User.Age = 19;
            //    Console.WriteLine($"Name: {u.User.Name} Age :{u.User.Age}");
            //}

            ////projection
            //var names = users.Select(u=>u.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //var usersWithAnonymousType = from user in users
            //                        select new
            //                        {
            //                            Firstname = user.Name,
            //                            DateOfBirth = DateTime.Now.Year -  user.Age
            //                        };
            //foreach (var user in usersWithAnonymousType)
            //{
            //    Console.WriteLine($"Firstname : {user.Firstname} Date Of Birth: {user.DateOfBirth}");
            //}

            //var namesWithLet = from user in users
            //                   let name = "Dear " + user.Name
            //                   select new 
            //                   {
            //                   Name = name,
            //                   Age = user.Age,
            //                   languages = user.Languages
            //                   }
            //                   ;
            //foreach (var user in namesWithLet)
            //{
            //    Console.WriteLine($"{user.Name} Age: {user.Age}");
            //}

            //List<Customer> customers = new List<Customer> { new Customer {Name = "Alex" },new Customer {Name = "Oleg" } };
            //List<Phone> phones = new List<Phone> { new Phone { Name = "Nokia" }, new Phone { Name = "Lumia" } };

            //var collection = from customer in customers
            //                 from phone in phones
            //                 select new { customer = customer.Name, phone = phone.Name };
            //foreach (var record in collection)
            //{
            //    Console.WriteLine($"Customer : {record.customer} Phone:{record.phone}");
            //}
            //var sortedByNameDescendingCollection = customers.OrderByDescending(customer => customer.Name);
            //Console.WriteLine("Normal order:");
            //foreach (var record in customers)
            //{
            //    Console.WriteLine($"Customer : {record.Name}");
            //}
            //Console.WriteLine("Decsending order:");
            //foreach (var record in sortedByNameDescendingCollection)
            //{
            //    Console.WriteLine($"Customer : {record.Name}");
            //}

            List<User> users = new List<User>
            {
                new User {Name="Tom", Age=99, Languages = new List<string> { "English", "Deuch" }},
                new User {Name="Tom", Age=33, Languages = new List<string> { "English", "Deuch" }},
                new User {Name="Tom", Age=97, Languages = new List<string> { "English", "Deuch" }},
                new User {Name="Tom", Age=24, Languages = new List<string> { "English", "Deuch" }},
                new User {Name="Bob", Age=27, Languages = new List<string> { "English", "France" }},
                new User {Name="John", Age=29, Languages = new List<string> {"English", "Spanish" }},
                new User {Name="Alice", Age=24, Languages = new List<string> {"Spanish", "Deuch" }}
            };
            var complexSort = users.OrderBy(u=> u.Name).ThenBy(u=>u.Age);

            foreach (var user in complexSort)
            {
                Console.WriteLine($"Name: {user.Name} Age :{user.Age}");
            }

        }
        class Phone
        {
            public string Name { get; set; }
        }
        class Customer 
        {
            public string Name { get; set; }
            Phone Phone { get; set; }
        }
    }
}
