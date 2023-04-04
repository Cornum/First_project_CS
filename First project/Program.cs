using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());


            while (age-->0)
            {
                if (age == 10)
                {
                    continue;
                }
                Console.WriteLine(age);
            }

            for (int i=0; i <= 100; i+=2)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
