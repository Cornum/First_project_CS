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
            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            petrovich = ivanovich;
            petrovich[0] = 5;
            petrovich[1] = 3;
            Console.WriteLine(ivanovich[0]);
            Console.WriteLine(ivanovich[1]);
        }
    }
}
