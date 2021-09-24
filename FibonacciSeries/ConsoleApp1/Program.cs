using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int previousPrevious = 0;
            int previous = 1;

            String series = previousPrevious + "+" + previous;
            int tempsum;
            int i = 3;
            while (i <= n)
            {
                tempsum = previous + previousPrevious;
                previousPrevious = previous;
                previous = tempsum;
                series = series + "+" + tempsum;
                tempsum = 0;
                i++;
            }
            Console.WriteLine(series);
        }
    }
}
