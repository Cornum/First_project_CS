using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Table[] tables = { new Table(1,4), new Table(2,8), new Table(3,10)};

            while (isOpen)
            {
                Console.WriteLine("Administration menu.\n");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                MakeReservation(tables);

                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void MakeReservation(Table[] tables)
        {
            Console.Write("\nEnter table number:");
            int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Enter desired places: ");
            int desirePlaces = Convert.ToInt32(Console.ReadLine());

            bool isReservationCompleted = tables[wishTable].Reserve(desirePlaces);

            if (isReservationCompleted)
            {
                Console.WriteLine("Reservation completed.");
            }
            else
            {
                Console.WriteLine("Not enough places.");
            }
        }
    }
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Table: {Number}.\nFree places: {FreePlaces} out of {MaxPlaces}.\n");
        }
        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}

