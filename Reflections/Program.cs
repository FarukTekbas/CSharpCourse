﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(3, 4));
            //Console.WriteLine(dortIslem.Topla2());

            var tip = typeof(DortIslem);
            // new lemeyle aynı şey
            // Activator.CreateInstance(tip);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla2()); 
            //Console.WriteLine(dortIslem.Topla(2, 3)); 

            var instance = Activator.CreateInstance(tip, 6, 7);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            var methodlar = tip.GetMethods();
            foreach (var item in methodlar)
            {
                Console.WriteLine("Method Adı: " + item.Name);
                foreach (var parameterInfo in item.GetParameters())
                {
                    Console.WriteLine("Parametre: " + parameterInfo.Name);
                }
                foreach (var attributeInfo in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: " + attributeInfo.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }




    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
