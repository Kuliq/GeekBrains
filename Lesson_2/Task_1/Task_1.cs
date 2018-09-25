using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Task_1
    {
        //Кулик В.В.
        //1. Написать метод, возвращающий минимальное из трех чисел

        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var a = int.Parse( Console.ReadLine());
            Console.Write("Введите второе число: ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное из введенных: {Min(a,b,c)}");
            Console.ReadKey();
        }
    }
}
