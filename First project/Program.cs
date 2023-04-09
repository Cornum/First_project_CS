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
            ferrari.ShowTechnicalPasport();
            ferrari.BecomeOlder(10,20);
            ferrari.ShowTechnicalPasport();
        }
    }

    class Car 
    { // по умолчанию private
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;
        float _minSpeed;

        public void ShowTechnicalPasport()
        {
            Console.WriteLine($"Name auto - {Name}\n" +
                $"Amount of horse power - {HorsePower}\nAuto age - {Age}\n" +
                $"Max speed - {MaxSpeed} km/h");
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }
    }
}

