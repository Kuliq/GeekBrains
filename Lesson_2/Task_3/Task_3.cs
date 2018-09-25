using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Task_3
    {
        //Кулик В.В.
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
        
        static void Main(string[] args)
        {
            int a = 1;
            int sum = 0;
            while (a != 0) { 
                Console.Write("Введите число: ");
                a = int.Parse(Console.ReadLine());          
                if (a > 0 && a % 2 != 0)
                {
                    sum = sum + a;
                }
                
            }
            Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");
            Console.ReadLine();
        }
    }
}
