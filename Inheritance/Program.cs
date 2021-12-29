using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Student{FirstName="Ahsen"},new Customer{FirstName="Faruk" },new Person{FirstName="Kemal"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            //Customer customer = new Customer();
            //customer.FirstName = "Faruk";
            //customer.City = "Kayseri";


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
