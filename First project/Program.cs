using System;
using System.Collections.Generic;
using System.Linq;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player> { 
                new Player("John",100),
                new Player("Bill",200),
                new Player("Derek",260),
                new Player("Clark",241)
            };

            var filteredPlayers = from Player player in players where player.Level > 200 select player;


            foreach (Player player in filteredPlayers)
            {
                Console.WriteLine(player.Login);
            }
        }
    }
    class Player
    {
        public string Login { get; private set; }
        public int Level { get; private set; }

        public Player(string login, int level) {
        Login = login;
        Level = level;}
    }
}

