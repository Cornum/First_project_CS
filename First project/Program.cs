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
        //Comp club -> 1 person per 1 pc per some time
        static void Main(string[] args)
        {
            ComputerClub computerClub = new ComputerClub(8);
            computerClub.Work();
        }
    }
    class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();

        public ComputerClub(int computersCount)
        {
            Random rnd = new Random();
            for (int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(rnd.Next(5, 15)));

            }
            CreateNewClients(25, rnd);
        }
        public void CreateNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _clients.Enqueue(new Client(random.Next(100, 251), random));
            }
        }
        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue();
                Console.WriteLine($"Balance PCC is {_money}$. Waiting for new client.");
                Console.WriteLine($"You have new client and he wants to buy {newClient.DesiredMinutes} minutes");
                Console.WriteLine($"In queue still {_clients.Count} clients");
                ShowAllComputersState();

                Console.Write("\nYou offer him PC number: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;
                    if (computerNumber >= 0 && computerNumber <= _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine("You are trying to give client PC which is already taken. He has angry and gone.");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("Client check his money, payed and sit on his PC " + (computerNumber + 1));
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomeTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("Client didn't have enough money. He is gone.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't know where him ot sit. He has angry and gone.");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Wrong input! Try again.");
                }

                Console.WriteLine("To start work with new client press any button...");
                Console.ReadKey();
                Console.Clear();
                SpendOneMinute();
            }
        }
        public void ShowAllComputersState()
        {
            Console.WriteLine("\nList of all computers:");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i + 1 + " - ");
                _computers[i].ShowState();
            }
        }
        private void SpendOneMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SpendOneMinute();
            }
        }
    }
    class Computer
    {
        private Client _client;
        private int _minutesRemainig;
        public bool IsTaken
        {
            get
            {
                return _minutesRemainig > 0;
            }
        }
        public int PricePerMinutes { get; private set; }

        public Computer(int pricePerMinutes)
        {
            PricePerMinutes = pricePerMinutes;
        }

        public void BecomeTaken(Client client)
        {
            _client = client;
            _minutesRemainig = _client.DesiredMinutes;
        }
        public void BecomeEmpty()
        {
            _client = null;
        }
        public void SpendOneMinute()
        {
            _minutesRemainig--;
        }
        public void ShowState()
        {
            if (IsTaken) { Console.WriteLine($"PC is taken, remaining: {_minutesRemainig} minutes"); }
            else Console.WriteLine($"PC is free, price per minute is {PricePerMinutes} $");
        }

    }
    class Client
    {
        private int _money;
        private int _moneyToPay;
        public int DesiredMinutes { get; private set; }
        public Client(int money, Random random)
        {
            _money = money;
            DesiredMinutes = random.Next(10, 30);
        }

        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = DesiredMinutes * computer.PricePerMinutes;
            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }

        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}

