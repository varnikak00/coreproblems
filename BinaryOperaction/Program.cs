using System;

namespace BinaryOperaction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArr = new int[8];
            int[] reverseArr = new int[8];
            int[] nibble1 = new int[4];
            int[] nibble2 = new int[4];
            for (int i = 0; num > 0; i++)
            {
                binaryArr[i] = num % 2;
                num = num / 2;
            }
            for (int i = 0; i < binaryArr.Length; i++)
            {
                Console.Write(binaryArr[i]);
                if (i < 4)
                {
                    nibble1[i] = binaryArr[i];
                }
                else
                {
                    nibble2[i - 4] = binaryArr[i];
                }
            }
            var myList = new List<int>();
            myList.AddRange(nibble2);
            myList.AddRange(nibble1);
            reverseArr = myList.ToArray();
            string addition = " ";
            double temp = 0;
            double sum = 0;
            int count = 7;
            Console.WriteLine("\n");
            for (int i = 0; i < reverseArr.Length; i++)
            {
                Console.Write(reverseArr[i]);
                if (reverseArr[i] == 1)
                {
                    temp = Math.Pow(2, count);
                    sum += temp;
                }
                addition = addition + temp.ToString() + "+";
                count--;
            }
            Console.WriteLine("\n");
            addition = addition.Remove(addition.Length - 1, 1);
            Console.WriteLine("reverse number is {0}", sum);
            Console.WriteLine(addition);
        }
    }
}
