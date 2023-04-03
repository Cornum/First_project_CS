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
            /*float result;
            int x=5, y=2;
            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);
            Console.ReadKey();
            */
            /*int timeInMinute = 1500, hour, minute;
            hour = timeInMinute / 60; 
            minute = timeInMinute % 60;
            Console.WriteLine(hour + " : " +minute);
            */
            /*int age = 17;
            bool accessIsAllowed;
            accessIsAllowed = age >= 18;
            Console.WriteLine(accessIsAllowed);
            */
            /*int age = 10;
            string name = "Den";
            Console.WriteLine(name + " is " + age*2 + " y.o.");
            Console.WriteLine($"{name} is {age*2} y.o.");
            */
            /*int age;
            string input = "12";
            age = Convert.ToInt32(input);
            Console.WriteLine(age);

            float result;
            int x = 5, y = 3;
            Console.WriteLine(result = Convert.ToSingle(x)/y);

            bool yInBoolean = Convert.ToBoolean(y);
            Console.WriteLine(yInBoolean);
            */
            /*Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введите ваше имя: ");
            string name;
            name = Console.ReadLine();
            Console.Write($"Ваше имя: {name}.\nВведите ваш возраст: ");
            int age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Вам: {age}");
            */

            //Practice Damage
            /*float health;
            int armor, damage;
            int percentConverter = 100;
            Console.Write("Введите свое здоровье: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите уровень брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите полученный урон: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * (Convert.ToSingle(armor) / percentConverter);
            Console.WriteLine($"Вам нанесли {damage} урона, у вас осталось {health} здоровья");
            */
            /*int age;
            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine()); 
            if (age >= 18)
            {
                Console.WriteLine("Добро пожаловать в наш бар!");
                Console.WriteLine("Poka");
            }
            else
            {
                Console.WriteLine("Вы слишком юны");
                Console.WriteLine("Приходите через " + (18 - age) + " лет.");
            }
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введите день недели: ");
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "понедельник")
            {
                Console.WriteLine("Сегодня курс!");
            }
            else if (dayOfWeek == "вторник")
            {
                Console.WriteLine("Делаем дз");
            }

        }
    }
}
