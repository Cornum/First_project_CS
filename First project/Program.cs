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
            /*int[] array = { 2, 3, 4, 7, 8 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);

            int[] array2 = { 1, 3, 5, 8, 12, 2, 25 };
            int maxElement = int.MinValue;

            for (int i = 0; i < array2.Length; i++)
            {
                if (maxElement < array2[i])
                {
                    maxElement = array2[i];
                }
            }
            Console.WriteLine(maxElement);
            */
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 - забронировать места.\n\n2 - exit.\n\n");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine())-1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Не существует данный сектор.");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if(userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверное количество мест");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"Недостаточно мест в секторе {userSector+1}. " +
                                $"Остаток {sectors[userSector]}.");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронивание успешно");
                        break;
                    case 2:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестня команда");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
