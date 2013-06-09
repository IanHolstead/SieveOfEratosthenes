using System;
using System.IO;
using System.Diagnostics;

namespace WeeklyChallenges
{
    class Primes
    {
        static void Main()
        {
            int input;

            input = Ui(); 
            Stopwatch sw = Stopwatch.StartNew();
            FindSmallPrimes(input);
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        static int Ui()
        {
            int input=0;

            Console.WriteLine("Welcome to the prime number finder");
            Console.WriteLine("How high would you like to seach?");

            do
            {
                if(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("invalid input, try again");
                }
            }
            while (input <= 1);

            return input;
        }

        static void FindSmallPrimes(int length)
        {
            bool[] data = new bool[length+1];
            int count = 2;

            for (int i = 2;(i * i) < data.Length; i++)
            {
                if (!data[i])
                {
                    for (int p = 2; p * i < data.Length; p++)
                    {
                        if (!data[p * i])
                        {
                            data[p * i] = true;
                            count++;   
                        }
                    }
                }
            }
            count = data.Length - count;
            Console.WriteLine("total primes: {0}", count);
        }
    }
}
