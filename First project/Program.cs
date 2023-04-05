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
            string[,] books = {
                { "Pushkin A.","Lermontov M.","Esenin S."},
                { "Martin R.","Shell J.","Teplyakov S."},
                { "King S.","Lovecraft H.","Stocker B."}
            };
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Array of all authors:\n\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Library");
                Console.WriteLine("\n\n1 - find author by index.\n2 - find book by author.\n3 - exit.");
                Console.Write("Make a choise: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Enter line number: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter column number: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"This author is {books[line - 1, column - 1]}");
                        break;
                    case 2:
                        Console.Write("Enter the author: ");
                        bool authorIsFound = false;
                        string author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Author {books[i, j]} is on line {i + 1}, " +
                                        $"column {j + 1}");
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine($"Author {author} isn't found.");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        Console.WriteLine("Bye bye!");
                        break;
                    default:
                        Console.WriteLine("Error! Unknown order!");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nPress any buton...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
