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
            Behavior[] behaviours =
            {
                new Walker(),
                new Jumper()
            };

            while (true)
            {
                foreach (var behaviour in behaviours)
                {
                    behaviour.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
    class Behavior
    {
        public virtual void Update()
        {

        }
    }
    class Walker : Behavior
    {
        public override void Update()
        {
            Console.WriteLine("Walk.");
        }
    }
    class Jumper : Behavior
    {
        public override void Update()
        {
            Console.WriteLine("Jump.");
        }
    }
}

