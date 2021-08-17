using System;
using System.Collections.Generic;

namespace GenericsUsercase
{
   public class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T [] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("_____________");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
            
        }
    }
}
