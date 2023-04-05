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
            int treasureCount = 0;
            bool isOpen = true;
            Console.CursorVisible = false;
            char[,] map = {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#','X','#',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ','X','#'},
                { '#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ','#',' ',' ',' ',' ',' ',' ',' ','#','#','#','#',' ',' ','#'},
                { '#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','X','#',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#'},
                { '#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#'},
                { '#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#'},
                { '#',' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','X',' ','#',' ',' ','X',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','X','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'X')
                    {
                        treasureCount++;
                    }
                }
            }

            int userX = 6, userY = 6;
            char[] bag = new char[1];

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Bag: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        isOpen = false;
                        break;
                }

                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                    treasureCount--;
                }
                if (treasureCount == 0)
                {
                    isOpen = false;
                }
                Console.Clear();
                Console.ReadKey();
            }
            Console.WriteLine("Thank you for playing!");
        }
    }
}
