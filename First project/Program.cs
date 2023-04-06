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
            Queue<string> patients = new Queue<string>();

            patients.Enqueue("Vasiliy");
            patients.Enqueue("Alexey");
            patients.Enqueue("Roman");
            patients.Enqueue("Vladimir");

            Console.WriteLine("Here is " + patients.Dequeue());

            Console.WriteLine("Next will be " + patients.Peek());
            foreach (var patien in patients)
            {
                Console.WriteLine(patien);
            }
        }
    }
}

