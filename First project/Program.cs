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
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);    
            numbers.Push(6);    
            numbers.Push(4);    
            numbers.Push(5);

            //Console.WriteLine(numbers.Peek());

            //numbers.Pop();

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            while(numbers.Count > 0)
            {
                Console.WriteLine("Next in stack is " + numbers.Pop());
            }

        }
    }
}

