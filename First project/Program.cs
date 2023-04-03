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
            string password = "123qwe";
            Console.WriteLine("Введите пароль от ячейки");
            string userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Пароль принят. Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Неверный пароль. Полиция была вызвана.");
                Console.SetWindowSize(800, 600);
            }
            float rublesInWallet, dollarsInWallet;
            int rubToUsd = 64, usdToRub = 66;
            float exchangeCurrencyCount;
            
            Console.WriteLine("Добро пожаловать в обменник валют!");
            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию.");
            Console.WriteLine("1 - обменять рубли на доллары.");
            Console.WriteLine("2 - обменять доллары на рубли.");
            Console.Write("Ваш выбор: ");
            string desiredOperation = Console.ReadLine();
            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.WriteLine("Сколько вы хотите поменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.WriteLine("Сколько вы хотите поменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверно введены данные.");
                    break;
            }
            Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей и " + $"{dollarsInWallet} долларов.");
        }
    }
}
