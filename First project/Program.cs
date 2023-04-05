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
            int z=3, y=11, sum;
            sum = Sum(z, y) + z + y;
            Console.WriteLine(Sum(2,3));
        }

        static int Sum(int x, int y) 
        {
            int sum;
            sum = x + y;
            return sum;
        }
    }
}
