using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Task_4
    {
        //Кулик В.В.
        //4. Реализовать метод проверки логина и пароля.На вход подается 
        //логин и пароль.На выходе истина, если прошел авторизацию, и ложь,
        //если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: 
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.

            /// <summary>
            /// Проверка логина и пароля
            /// </summary>
            /// <param name="log">Логин</param>
            /// <param name="pass">Пароль</param>
            /// <returns>true или false</returns>
        private static bool Acc(string log, string pass)
        {
            bool req;
            if (log == "root" && pass == "GeekBrains") req = true;
            else req = false;
            return req;
        }

        static void Main(string[] args)
        {
            int i = 0;

            do
            {   
                //Блок ввода данных

                Console.Write("Логин: ");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                i++;

                //Проверка на условие совпадение логина и пароля

                if (Acc(login, password) == true)
                {
                    Console.WriteLine("Вы прошли проверку!");
                }
                else if (i < 3) Console.WriteLine("Неверный логин или пароль. Попробуйте еще раз..");
                else {
                    Console.WriteLine("Доступ ограничен.");
                    break;
                }
            }
            while (i < 3);
           
        Console.ReadKey();

        }
    }
}
