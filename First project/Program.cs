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
            IMovable car = new Car();
            IMovable man = new Human();
        }
    }
    interface IBurnable
    {
        void Burn();
    }
    interface IMovable
    {
        void Move();
        void ShowMoveSpeed();
    }
    class Vehicle { }
    class Car : Vehicle, IMovable, IBurnable
    {
        public void Move() 
        { 

        }
        public void ShowMoveSpeed() 
        {

        }
        public void Burn() { }
    }
    class Human : IMovable
    {
        public void Move()
        {

        }
        public void ShowMoveSpeed()
        {

        }
    }
}

