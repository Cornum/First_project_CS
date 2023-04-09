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

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
            }
            WhoIsWinner(firstFighter, secondFighter);

        }
        static void WhoIsWinner(Fighter firstFighter, Fighter secondFighter)
        {
            if (firstFighter.Health <= 0 && secondFighter.Health <= 0) { Console.WriteLine("Tie."); }
            else if (firstFighter.Health <= 0) { Console.WriteLine($"Winner is {secondFighter.Name}."); }
            else if (secondFighter.Health <= 0) { Console.WriteLine($"Winner is {firstFighter.Name}."); }
            else { Console.WriteLine("Error!"); }
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
        public int Damage { get{ return _damage; } }
        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Fighter - {_name}, HP - {_health}, " +
                $"Given damage - {_damage}, Armor - {_armor}");
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} HP - {_health}");
        }
        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }
    }
}

