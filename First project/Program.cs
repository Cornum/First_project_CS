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
            int sum = 0, x = 1, y = 5;
            //Отправляет значения в переменных
            Add(sum, x, y);
            //Отправляет ссылку на место Sum в памяти. Должны сначала инициализировать
            Add2(ref sum, x, y);
            //Отправляет ссылку на место Sum в памяти. Инициализирует память сама.
            int sum2;
            Add3(out sum2, x, y);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);

            int[] array = new int[5];
            int[] array2 = new int[5];
            EditArray(array, 2, 5);
            Console.WriteLine(array[2]);
            array2 = EditArrayR(array, 2, 5);
            Console.WriteLine(array2[2]);
        }

        static void Add(int sum, int x, int y)
        {
            sum = x + y;
        }
        static void Add2(ref int sum, int x, int y)
        {
            sum = x + y;
        }
        static void Add3(out int sum, int x, int y)
        {
            sum = x + y;
        }

        static void EditArray(int[] array, int index, int value)
        {
            array[index] = value;
        }
        static int[] EditArrayR(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
    }
}
