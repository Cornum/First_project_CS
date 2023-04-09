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
            GameObject bullet =new GameObject();

            //bullet.Position.X = 50; WRONG
            Console.WriteLine(bullet.Position.X);
            Vector2 newPosition = bullet.Position;
            newPosition.X = 50;
            bullet.Position = newPosition;
            Console.WriteLine(bullet.Position.X);


            Vector2 targetPosition = new Vector2(10,10);
            Vector2 playerPosition = targetPosition;

            playerPosition.X += 15;

            Console.WriteLine(targetPosition.X); //show value type of struct
        } 
    }
    class GameObject
    {
        public Vector2 Position { get; set; }
    }
    struct Vector2
    {
        public int X, Y;
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

