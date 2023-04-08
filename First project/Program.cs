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
            Car ferrari = new Car(); //Выделяет память под класс Car
            //Все созданные классы имеют ссылочный тип
            Random rand = new Random();
            ferrari.Name = "F40";
            ferrari.HorsePower = 471;
            ferrari.Age = 30;
            ferrari.MaxSpeed = 317.0f;

            Car maserati;

            maserati = ferrari;

            maserati.HorsePower = 1000;

            Console.WriteLine(ferrari.HorsePower);
        }
    }

    class Car 
    { // по умолчанию private
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;
        float _minSpeed;
    }
}

