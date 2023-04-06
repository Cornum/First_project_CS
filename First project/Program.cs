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
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(14);
            numbers.Add(22);

            numbers.AddRange(new int[] { 3, 8, 4, 1 });

            numbers.RemoveAt(3);

            numbers.Remove(5);

            numbers.Insert(1, 123);

            Console.WriteLine("First apearence of number 8 is " + numbers.IndexOf(8));
            //numbers.Clear();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

