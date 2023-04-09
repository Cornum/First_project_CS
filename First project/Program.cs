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
            Renderer render = new Renderer();
            Player player = new Player(55, 10, 10);

            render.Draw(player.GetPositionX(), player.Y);
            //player.Y == 100;

        }
    }
    class Renderer
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
            Console.ReadKey(true);
        }
    }
    class Player
    {
        private int _x;
        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
            private set
            {
                if (Y > 0 && Y < 100)
                    _y = value;
            }
        }
        public int Z { get; private set; }
        public Player(int x, int y, int z)
        {
            _x = x;
            _y = y;
            Z = z;
        }

        public int GetPositionX()
        {
            return _x;
        }

    }
}

