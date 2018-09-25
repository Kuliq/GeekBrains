using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Task_5
    {
        //Кулик В.В.
        //5. а) Написать программу, которая запрашивает массу и рост человека, 
        //    вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        //Расчет ИМТ
        private static float Imt(float h, float w) {
            return w / (h * h);
        }

        static void Main(string[] args)

        {
            
            // Блок вопросов

            Console.WriteLine("Какой у вас рост?"); //предполагаем, что вводим данные в см
            var h = float.Parse(Console.ReadLine());
            h = h / 100;
            Console.WriteLine("Какой у вас вес?");
            var w = float.Parse(Console.ReadLine());     

            //Блок переменных

            float delta=0;
            float min=18.5f;
            float max = 25;

            //Блок условий - проверяем выходит ли за рамки ИМТ и даем рекомендации

            Console.WriteLine($"Индекс массы тела: {Imt(h, w):F1}");
            if (min > Imt(h,w)) {
                delta = (min-Imt(h, w))*h*h;
                    if (delta < 0.1) Console.WriteLine("У вас все ОК!");
                    else Console.WriteLine("Надо бы поправиться килограмм на {0:F1}", delta);
            }
            else if (Imt(h, w) > max) {
                delta = (Imt(h, w)- max) * h * h;
                if (delta < 0.1) Console.WriteLine("У вас все ОК!");
                else Console.WriteLine("Пора похудеть на {0:F1} кг", delta);
            } 
            else Console.WriteLine("У вас все ОК!");
            Console.ReadKey();
        }
    }
}
