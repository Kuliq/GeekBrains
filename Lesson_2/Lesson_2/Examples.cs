using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Examples
    {
        enum Days { Fri, Mon };

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;

            #region ConsoleKey

            //ConsoleKeyInfo b;
            //b = Console.ReadKey();
            //Console.WriteLine(b.Key);
            //Console.ReadKey();

            #endregion

            #region Switch

            //int caseSwitch = 2;
            //switch (caseSwitch)
            //{
            //    case 1:
            //    case 11:
            //        Console.WriteLine("Case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Case 2");
            //        break;
            //    default:
            //        Console.WriteLine("Default case");
            //        break;
            //}
            //Console.ReadKey();

            #endregion

            #region Enum

            //Days day = Days.Mon;
            //switch (day)

            //{
            //    case Days.Fri: Console.WriteLine("5"); Console.ReadKey(); break;
            //    case Days.Mon: Console.WriteLine("1"); Console.ReadKey(); break;
            //}

            #endregion

            #region Foreach

            string s = "Hello, Foreach";
            foreach (char c in s)
            Console.Write("{0}  _  ", c);
            Console.ReadKey();

            #endregion
        }
    }
}
