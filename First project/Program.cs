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
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100. Оно больше чем {lower}, " +
                $"но меньше чем  {higher}.");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");

            while (triesCount-- > 0)
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Вы правы, это было " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно. Попробуйте ещё раз.");
                }
            }
            if (triesCount < 0)
            {
                Console.WriteLine("Вы проиграли. Это было число " + number + ".");
            }
        }
    }
}
