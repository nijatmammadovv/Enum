using System;
using Enum;

namespace Enum
{
    class Test
    {
        static void Main(string[] args)
        {
            //Enum
            int day = 6;
            switch (day)
            {
                case (int) @enum.Days.Monday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Wake up school time");
                    Console.WriteLine("Monday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Tuesday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("You have to go to work today");
                    Console.WriteLine("Tuesday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Wednesday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Wednesday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Thursday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Thursday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Friday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Friday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Saturday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Saturday");
                    Console.WriteLine("---------------");
                    break;
                case (int)@enum.Days.Sunday:
                    Console.WriteLine("---------------");
                    Console.WriteLine("It's a day off");
                    Console.WriteLine("Sunday");
                    Console.WriteLine("---------------");
                    break;
                default:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Belə bir gün hələ kəşf olunmayıb!");
                    Console.WriteLine("---------------");
                    break;
            }

        }
    }
}