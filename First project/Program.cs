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
            Console.Write("Введите день недели: ");
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "понедельник":
                    Console.WriteLine("Идем в кино.");
                    Console.WriteLine("Едим попкорн.");
                    break;
                case "вторник":
                    Console.WriteLine("Учимся.");
                    break;
                case "среда":
                    Console.WriteLine("Пишем код.");
                    break;
                case "четверг":
                    Console.WriteLine("Кушаем мясо.");
                    break;
                case "пятница":
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("Чиллим.");
                    break;
                default:
                    Console.WriteLine("Не знаю такой день...");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
