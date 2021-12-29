using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1 ,number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Add2(10, 20));
            // Multiply overLoad oldu bu durumda
            Console.WriteLine(Multiply(10, 20));
            Console.WriteLine(Multiply(10, 20,2));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        // ref dersek eğer number1 in  değeride etkileniyor.
        // eğer değer baştan set edilmemişse out kullanılır ref yerine ama outta dışarıda set edilse bile içeridede set edilmesi gerekir
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2*number3;
        }
        // params asayesinde istediğimiz kadar int kullanabiliyoruz 
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
