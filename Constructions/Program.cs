using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product();

            EmployeeManager employeeManager = new EmployeeManager(new DataBaseLogger());
            // employeeManager.Logger = new FileLogger();
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            // static nesneler oratak nesnelerdir ve herkez onları kullanır
            Teacher.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        public ILogger _logger { get; set; }
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");

        }
    }
    class BaseClass
    {
        private string _entity;
       
        public  BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
