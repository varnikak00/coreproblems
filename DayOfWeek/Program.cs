﻿
using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
}

        private static void checkForDayOfWeek(int m, int d, int y)
        {
            int y1, x, m1, d1;
            y1 = (y - (14 - m)) / 12;
            x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            m1 = m + (12 * ((14 - m) / 12)) - 2;
            d1 = ((d + x + ((31 * m1) / 12))) % 7;
            System.String day = " ";
            switch (d1)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
            }
            Console.WriteLine("Day is" + day);
        }
    }
    }
