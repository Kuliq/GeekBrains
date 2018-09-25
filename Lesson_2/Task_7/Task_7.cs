using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Task_7
    {
        //Кулик В.В.
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Main(string[] args)
        {
            //Вводим промежуток
            Console.Write("Введите меньшее число промежутка: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите большее число промежутка: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ряд чисел указанного промежутка: ");
            
            Loop(a, b); //Вызываем метод вывода чисел
            Console.ReadLine();
            
            Console.Write("Сумма чисел указанного промежутка: ");
            Console.WriteLine(Sum(a, b)); //Вызываем метод вывода суммы
            Console.ReadLine();
        }
        /// <summary>
        /// Вывод последовательности чисел между двумя указанными
        /// </summary>
        /// <param name="a">Минимальное число промежутка</param>
        /// <param name="b">Максимальное число промежутка</param>
        static void Loop(int a, int b)
        {
            Console.Write("{0,3}", a);
            if (a < b) Loop(a + 1, b);//идем от a до b пока выполняется условие и выводим числа a с увеличением на 1
        }
        static int Sum(int a, int b)
        {
            if (a == b) return a; // идем от b к a и когда они становятся равными возвращаем a
            return Sum(a,b-1) + b; // возвращаем предыдущие шаги и прибавляем их к а
        }

    }
}
