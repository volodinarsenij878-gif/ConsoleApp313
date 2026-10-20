using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program152
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Номер дня недели (1–7): ");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                return;
            }

            if (day >= 1 && day <= 5)
            {
                Console.WriteLine("Будни");
            }
            else if (day == 6 || day == 7)
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Некорректный номер.");
            }
        }
    }
}