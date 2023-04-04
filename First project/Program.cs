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

            /*int triesCount = 5;
            string password = "123qwe";
            string userInput;

            for(int i=0; i<triesCount; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine(); 
                if(userInput == password)
                {
                    Console.WriteLine("Секретные данные.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль.");
                    Console.WriteLine($"У вас осталось {triesCount-(i+1)} попыток");

                }
            }*/
            /*float money;
            int years, percent;

            Console.Write("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("На сколько лет открыт вклад?");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Под какой процент?");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money * percent / 100;
                Console.WriteLine($"В {i+1} году у вас {money} рублей.");
                Console.ReadKey();
            }*/
            int playerHealth = 1000, playerDamage = 5;
            int enemyHealth = 1000, enemyDamage = 5;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " - игрок.");
                Console.WriteLine(enemyHealth + " - враг.");
            }

            if(playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока.");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Победа врага.");
            }
        }
    }
}
