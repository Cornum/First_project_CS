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
            int[] cucumbers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue };
            int[] Cucum = new int[5] { 1, 3, 5, 8, 6 };

            for (int i = 0; i < Cucum.Length; i++)
            {
                Console.Write(cucumbers[i] + " ");
                Console.Write(Cucum[i] + "-");
            }
        }
    }
}
