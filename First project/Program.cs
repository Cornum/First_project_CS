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
        static void Main(string[] args) // для пустых классов (Warrior из практики боя.)
        {
            Vehicle[] vehicles = { new Car() , new Train()};
            foreach (var vehicle in vehicles)
            {
                vehicle.GetCurrentSpeed();
            }
        }
    }
    abstract class Vehicle
    {
        protected float Speed;

        public abstract void Move();

        public float GetCurrentSpeed()
        {
            return Speed;
        }
    }
    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car ride on the road.");
        }
    }
    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Train ride on the kolej.");
        }
    }
}

