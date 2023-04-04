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
            /*Random rand = new Random();
            int value;

            while (true)
            {
                value = rand.Next(0, 10);
                Console.WriteLine(value);
                Console.ReadKey();
            }*/
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rand.Next(0, 5));
            }

        }
    }
}
