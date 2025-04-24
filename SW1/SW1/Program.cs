using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Холявко Богдан Станіславович; варіант №23; група: БІКСб-2-24-4.0д\n");
            int number;

            while (true)
            {
                Console.Write("Введіть чотиризначне натуральне число: ");
                if (int.TryParse(Console.ReadLine(), out number) && number >= 1000 && number <= 9999)
                    break;

                Console.WriteLine("Помилка! Потрібно ввести чотиризначне натуральне число.");
            }

            int digit1 = number / 1000;
            int digit2 = (number / 100) % 10;
            int digit3 = (number / 10) % 10;
            int digit4 = number % 10;

            digit3 = (digit3 == 9) ? 0 : digit3 + 1;

            int newNumber = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Перетворене число: {newNumber}");
        }
    }
}
