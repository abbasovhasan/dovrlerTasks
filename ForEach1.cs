/*using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DovrlerTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int countDivisibleBy2 = 0;

            int countCantDivisibleBy2 = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    countDivisibleBy2++;
                }
                else
                {
                    countCantDivisibleBy2++;
                }
            }

            int[] divisibleBy2 = new int[countDivisibleBy2];
            int[] notDivisibleBy2 = new int[countCantDivisibleBy2];

            int indexDivisibleBy2 = 0;
            int indexNotDivisibleBy2 = 0;

            foreach (int num2 in divisibleBy2)
            {
                if (num2 % 2 == 0)
                {
                    divisibleBy2[indexDivisibleBy2++] = num2;
                }
                else
                {
                    notDivisibleBy2[indexNotDivisibleBy2++] = num2;
                }
            }
            Console.Write("2 ye bölünen sayılar: ");
            foreach (int number in divisibleBy2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.Write("2 ye bölünmeyen sayılar: ");
            foreach (int number in notDivisibleBy2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            int oddSum = 0, evenSum = 0;
            foreach (int number in array)
            {

                if (number % 2 == 0)
                {
                    Console.Write("Cut ededler: " + number + " ");
                    evenSum = number + evenSum;
                }
                else if (number % 2 == 1)
                {
                    Console.Write("Tek ededler: "+number + " ");
                    oddSum = number + oddSum;
                }
            }
            Console.WriteLine("Cut ededlerin cemi: {0} ",evenSum);
            Console.WriteLine("Tek ededlerin cemi: {0}",oddSum);
        }
    }

}

*/