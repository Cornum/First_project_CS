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
            Random rand = new Random();
            float health1 = rand.Next(90, 110); 
            int damage1 = rand.Next(7, 36), armor1 = rand.Next(45, 100);
            float health2 = rand.Next(80, 120);
            int damage2 = rand.Next(5, 40), armor2 = rand.Next(65, 100);

            Console.WriteLine($"Glad 1 - {health1} hp, {damage1} dmg, {armor1} arm");
            Console.WriteLine($"Glad 2 - {health2} hp, {damage2} dmg, {armor2} arm");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
                Console.WriteLine("Glad 1 hp - " + health1);
                Console.WriteLine("Glad 2 hp - " + health2);
            }

            if(health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Died both.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Died glad 1.");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Died glad 2.");
            }
        }
    }
}
