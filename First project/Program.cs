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
            Console.WriteLine("Hello!");
            Console.WriteLine("Are you here?");
            WriteError("No signal");
            Console.WriteLine("Strange...");
            WriteError("Inthernet wasn't paid.", ConsoleColor.Yellow);
            WriteError("Pay first.", symbol: '@');
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!') //Необязательный всегда в конце параметров
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(symbol + text);
            Console.ForegroundColor = defaultColor;
        }
    }
}
