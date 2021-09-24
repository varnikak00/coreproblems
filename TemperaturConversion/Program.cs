using System;

namespace TemperaturConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double far, cel;
            far = GetTemp("Far");
            cel = Celcius(far);
            DisplayResults(far, cel);


        }//end of main method

        public static double GetTemp(string temp)
        {
            string inputValue;
            double far;
            Console.WriteLine("Enter Fahrenheith Temp");
            inputValue = Console.ReadLine();
            far = double.Parse(inputValue);
            return far;
        }

        static double Celcius(double far)
        {

            double cel = 5.0 / 9.0 * (far - 32);
            return cel;

        }

        public static void DisplayResults(double far, double cel)
        {
            Console.WriteLine("Fahrenhieith temp {0:N2}", far);
            Console.WriteLine("C    ", cel);
            Console.ReadLine();
            return;
        }
    }//end of class
}
