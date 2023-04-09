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
            List<Game> games = new List<Game>();
            games.Add(new Game("Blck & Wht",Genre.Strategy));
            games.Add(new Game("The Witcher 3: Wild Hunt",Genre.RPG));
            games.Add(new Game("Sid Miser's Civ VI",Genre.Strategy));
            games.Add(new Game("Ori and the Will of the Wisps",Genre.Action));

            foreach (Game game in games)
            {
                game.ShowInfo();
            }
        }
    }
    enum Genre
    {
        Strategy,
        RPG,
        Action
    }
    class Game
    {
        private string _title;
        private Genre _genre;

        public Game(string title, Genre genre)
        {
            _title = title;
            _genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"This is: {_title}, {(int)_genre} game.");
        }
    }
}

