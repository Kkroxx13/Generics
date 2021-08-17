using System;
using System.Collections.Generic;

namespace GenericsUsercase
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Program.toPrint<int>(intArray);
            Console.WriteLine("_____________");
            Program.toPrint<char>(charArray);
            Console.WriteLine("_____________");
            Program.toPrint<double>(doubleArray);
        }

        public static void toPrint<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
