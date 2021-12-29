using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionsIntro();
            TryCatch();
            ActionDemo();

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3,4));
            //Console.WriteLine(Topla(2,3));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Func<int> getRandomNumber2 =()=>new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }
        static int Topla(int x,int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            // Method
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }

        private static void ExceptionsIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Faruk", "Salih" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTİONS  = " + exception);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException);
            }
        }
    }
}
