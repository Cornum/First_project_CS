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
            NonPLayerCharacter[] characters =
            {
            new NonPLayerCharacter(),
            new Farmer(),
            new Knight(),
            new Child()
            };
            foreach (var character in characters)
            {
                character.ShowDescription();
                Console.WriteLine(new String('-', 40));
            }
        }
    }
    class NonPLayerCharacter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("I'm just NPC, i can walk only.");
        }
    }

    class Farmer : NonPLayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("Also i'm Farmer and can work on farm.");
        }
    }
    class Knight : NonPLayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("I'm knight, warcraft is my life!");
        }
    }
    class Child : NonPLayerCharacter
    {

    }
}

