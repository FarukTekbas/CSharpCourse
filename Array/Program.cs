using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";
            //3 elemanlı array 
            string[] students = new string[3];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            // new e gerek kalmadanda tanımlanabilir
            string[] students2 = new[] { "Engin", "Derin", "Salih" };
            string[] students3 = { "Engin", "Derin", "Salih" };
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana", "Mersin"},
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("**************");
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
