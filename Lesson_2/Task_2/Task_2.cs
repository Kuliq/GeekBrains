using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task_2
    {
        //Кулик В.В.
        //2. Написать метод подсчета количества цифр числа

        private static int Count(int a)
        {
            int col=1;
            
            for (int i = 1; a >= 10; i++)
            {
                a = a / 10;
                col = ++col;
            }
            
            return col;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе: {Count(num)}");
            Console.ReadLine();

        }
    }
}
