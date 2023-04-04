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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.SetCursorPosition(5,10);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WindowHeight = 10;
            Console.WindowWidth = 35;

            Console.WriteLine("Привет, Андрей! \nКуда ты вчера делся? \nЯ убежал к ...");
            
            Console.ReadKey();
        }
    }
}
