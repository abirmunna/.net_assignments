using System;

namespace RandomAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 100000;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int value = rand.Next(0, 101);
                sum += value;
            }
            double average = (double)sum / n;
            Console.WriteLine("The average of 100000 random values between 0 and 100 is: " + average);
            Console.ReadLine();
        }
    }
}