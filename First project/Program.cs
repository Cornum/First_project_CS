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
                new Player("Jill",210),
                new Player("Derek",260),
                new Player("Jodah",241)
            };List<Player> players2 = new List<Player> {
                new Player("Clark",250),
                new Player("Dave",260),
            };

            var filteredPlayers = from Player player in players where player.Level > 200 select player;
            var filteredPlayer2 = players.Where(player => player.Level > 200).Select(player => player);
            var filteredPlayers3 = players.Where(player => player.Login.ToUpper().StartsWith("JO"));

            foreach (Player player in filteredPlayers3)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine();

            var orderedPlayersByLevel = players.OrderBy(player => player.Level);
            var orderedPlayersByLevel2 = players.OrderByDescending(player => player.Level);

            foreach (Player player in orderedPlayersByLevel)
            {
                Console.WriteLine(player.Login);
                Console.WriteLine(player.Level);
            }
            Console.WriteLine();
            foreach (Player player in orderedPlayersByLevel2)
            {
                Console.WriteLine(player.Login);
                Console.WriteLine(player.Level);
            }
            Console.WriteLine();
            List<int> numbers = new List<int> { 1, 5, 100, 0, 2, 1, 3, 4, 85, 9, 6, 4, 7 };
            int maxNumber = numbers.Max();

            Console.WriteLine(maxNumber);
            int minNumber = numbers.Min();
            Console.WriteLine(minNumber);
            var maxLevelPlayer = players.Max(player => player.Level);
            Console.WriteLine(maxLevelPlayer);

            var newPlayers = from Player player in players
                             select new
                             {
                                 Name = player.Login,
                                 dateOfBirth = DateTime.Now
                             };
            var newPlayers2 = players.Select(player => new { Name = player.Login, dateOfBirth = "Monday" });

            foreach (var player in newPlayers2)
            {
                Console.WriteLine(player.Name + " " + player.dateOfBirth);
            }
            Console.WriteLine();
            var unitedTeam = players.Union(players2);
            foreach (var player in unitedTeam)
            {
                Console.WriteLine(player.Login + " " + player.Level);
            }

            Console.WriteLine();

            var filteredPlayersForSkip = players.Skip(1);
            foreach (var player in filteredPlayersForSkip)
            {
                Console.WriteLine(player.Login + " " + player.Level);
            }

            Console.WriteLine();

            var filteredPlayersForTake = players.TakeWhile(player=> player.Login.ToUpper().StartsWith("J"));
            foreach (var player in filteredPlayersForTake)
            {
                Console.WriteLine(player.Login + " " + player.Level);
            }
            Console.WriteLine();
            Console.WriteLine();


            var filteredPlayersForTake2 = players.TakeWhile(player=> player.Login.ToUpper().StartsWith("J")).ToArray();
            Console.WriteLine(filteredPlayersForTake2.GetType());

        }
    }
    class Player
    {
        public string Login { get; private set; }
        public int Level { get; private set; }

        public Player(string login, int level)
        {
            Login = login;
            Level = level;
        }
    }
}

