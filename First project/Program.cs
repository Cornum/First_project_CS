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

            // Логическое И &&
            // Логическое ИЛИ ||
            int money = 500;
            int level = 10;

            if (money >= 500 && level >= 9)
            {
                Console.WriteLine("Добро пожаловать в нашу таверну!");
            }
            else
            {
                Console.WriteLine("Ты не достоин!!!");
            }
        }
    }
}
