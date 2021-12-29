using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList();
            List();


            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");


            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary.ContainsKey("Anahtar"));
            Console.WriteLine(dictionary.ContainsValue("Kelime"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adana");
            //Console.WriteLine(cities.Contains("Adana"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { FirstName = "Faruk", Id = 1 });
            //customers.Add(new Customer { FirstName= "Ahsen",Id = 2 });

            List<Customer> customers = new List<Customer>
            {
                new Customer { FirstName = "Faruk", Id = 1 },
                new Customer { FirstName = "Ahsen", Id = 2 }
            };

            //var count = customers.Count();
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Süleyman"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, FirstName="Sinan"},
                new Customer{Id=5, FirstName="Sakıp"}
            });

            // customers.Clear();
            int index = customers.IndexOf(customer2);

            Console.WriteLine("Index: {0}", index);
            int index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("LastIndex: {0}", index2);

            customers.Insert(0, customer2);

            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Süleyman");


            Console.WriteLine(customers.Contains(customer2));

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
