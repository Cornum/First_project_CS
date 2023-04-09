using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = {
            new Fighter("John", 500 , 50, 0),
            new Fighter("Mark", 250 , 25, 25),
            new Fighter("Alex", 150 , 100, 10),
            new Fighter("Jack", 300 , 75, 5),
            };
            int fighterNumber;

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                fighters[i].ShowStats();
            }
            Console.WriteLine("\n** " + new string('-', 25) + "**");
            Console.Write("\nEnter number of your first fighter: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter firstFighter = fighters[fighterNumber];

            Console.Write("Enter number of your second fighter: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter secondFighter = fighters[fighterNumber];
            Console.WriteLine("\n** " + new string('-', 25) + "**");

            WhoIsWinner(firstFighter, secondFighter);

        }
        static void WhoIsWinner(Fighter firstFighter, Fighter secondFighter)
        {
            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
            }
            if (firstFighter.Health <= 0 && secondFighter.Health <= 0) { WriteWithChangedColor("Tie.", ConsoleColor.DarkYellow); }
            else if (firstFighter.Health <= 0) { WriteWithChangedColor($"Winner is {secondFighter.Name}.", ConsoleColor.DarkYellow); }
            else if (secondFighter.Health <= 0) { WriteWithChangedColor($"Winner is {firstFighter.Name}.", ConsoleColor.DarkYellow); }
            else { WriteWithChangedColor("Error!", ConsoleColor.Red); }
        }
        static void WriteWithChangedColor(string text, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = defaultColor;
        }
    }
    class Fighter
    {
        private string _name;
        private int _health;
        private int _armor;
        private int _damage;

        public int Health { get { return _health; } }
        public string Name { get { return _name; } }
        public int Damage { get { return _damage; } }
        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }
        public void ShowStats()
        {
            WriteWithChangedColor("Fighter - " + _name + ", ", ConsoleColor.White);
            WriteWithChangedColor("Hp - " + _health + ", ", ConsoleColor.Green);
            WriteWithChangedColor("Given damage - " + _damage + ", ", ConsoleColor.Red);
            WriteWithChangedColor("Armor - " + _armor + ".", ConsoleColor.Cyan);
            Console.WriteLine();
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} HP - {_health}");
        }
        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }
        static void WriteWithChangedColor(string text, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = defaultColor;
        }
    }
}

