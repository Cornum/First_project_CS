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
        static void Main(string[] args) //Класс -ссылочный тип
            //Структура - тип значение.
        {
            Vector2 position;
            Vector2 position1 = new Vector2(10);
            //Console.WriteLine(position.X);
            Console.WriteLine(position1.X);
            Console.WriteLine(position1.Y);
            position.X = 10;

        } 
    }
    struct Vector2
    {
        public int X, Y;
        //public Vector2() { }
        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }public Vector2(int x) : this()
        {
            X = x;
        }
    }
    
}

