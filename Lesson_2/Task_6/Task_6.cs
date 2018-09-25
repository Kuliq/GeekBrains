using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_6
{
    //Кулик В.В.
    //6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    //Хорошим называется число, которое делится на сумму своих цифр.
    //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    class Task_6
    {
        // Метод подсчета суммы цифр числа
        private static int Sum (int num)
        {
            int summa = 0;
            for (var i = 0; num > 0; i++)
            {
                summa = summa + num % 10;
                num = num / 10;
            }
            return summa;
        }
        static void Main(string[] args)
        {
            //задаем счетчик времени
            DateTime One = DateTime.Now;

            int num = 1;
            int col = 0;
            int ch = 10000000; //число диапазона подсчета хороших чисел
            
            while (num < ch) //задаем диапазон повторений
            {
                //Проверяем условие дилится ли число без остатка на сумму цифр
                for (int i = 0; num % Sum(num) == 0; i++)
                {
                    col++;//если делится включаем счетчик
                    num++;
                }
                num++;
            }

            DateTime Two = DateTime.Now; //задаем счетчик времени
            TimeSpan Time = Two - One;
            Console.WriteLine($"Время, затраченное на расчёт, мc: {Time.Milliseconds.ToString()}");
            Console.WriteLine($"Количество \"хороших\" чисел от 1 до {ch}: {col}");
            Console.ReadLine();
        }
    }
}
