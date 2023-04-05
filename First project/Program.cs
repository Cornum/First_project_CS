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
            int health = 7, maxHealth = 10;
            int mana = 10, maxMana = 10;

            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, symbol: '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Enter number of health reduce: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number of mana reduce: ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();   
            }
        }
        static void DrawBar(int value, int maxValue, ConsoleColor color,
            int position = 0, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
