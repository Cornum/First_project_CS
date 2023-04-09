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
            Car maserati = new Car();
            Car ferrari = new Car("F40",-471,30,317.0f);

            Console.WriteLine(ferrari.HorsePower);
            ferrari.ShowTechnicalPasport();
            ferrari.BecomeOlder(10,20);
            Console.WriteLine();
            ferrari.ShowTechnicalPasport();
            Console.WriteLine();
            maserati.ShowTechnicalPasport();
        }
    }

    class Car 
    { // по умолчанию private
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;
        float _minSpeed;
        public int Years = 4;

        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            if(horsePower < 0)
            {
                HorsePower = 1;
            }
            else
            {
            HorsePower = horsePower;
            }
            Name = name;
            Age = age;
            MaxSpeed = maxSpeed;
        }
        public Car() 
        {
            Name = "Unnamed car";
            HorsePower = 1;
            Age = 1;
            MaxSpeed = 140;
        }

        public void ShowTechnicalPasport()
        {
            Console.WriteLine($"Name auto - {Name}\n" +
                $"Amount of horse power - {HorsePower}\nAuto age - {Age}\n" +
                $"Max speed - {MaxSpeed} km/h");
        }

        public void BecomeOlder(int Years, int runAwayHorses)
        {
            Age += this.Years + Years;
            HorsePower -= runAwayHorses;
        }
    }
}

