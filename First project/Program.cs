using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, world!");
            MyClass instance = new MyClass();
            MyClass instance1 = new MyClass();
            Console.WriteLine(MyClass.StaticField);
            Console.WriteLine(MyClass.StaticField);
        } 
    }
    class MyClass
    {
        public static float StaticField;

        static MyClass()
        {
            StaticField = 10;
            Console.WriteLine("Static constructor.");
        }

        public MyClass()
        {
            Console.WriteLine("Normal constructor.");
        }
    }
}

