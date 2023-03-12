using System;

namespace RandomValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int sum = 0;
            int numValues = 100000;
            int count0_25 = 0;
            int count25_50 = 0;
            int count50_75 = 0;
            int count75_100 = 0;

            for (int i = 0; i < numValues; i++)
            {
                int value = rand.Next(0, 101);
                sum += value;

                if (value >= 0 && value <= 25)
                {
                    count0_25++;
                }
                else if (value > 25 && value <= 50)
                {
                    count25_50++;
                }
                else if (value > 50 && value <= 75)
                {
                    count50_75++;
                }
                else if (value > 75 && value <= 100)
                {
                    count75_100++;
                }
            }

            double avg = (double)sum / numValues;
            double percent0_25 = (double)count0_25 / numValues * 100;
            double percent25_50 = (double)count25_50 / numValues * 100;
            double percent50_75 = (double)count50_75 / numValues * 100;
            double percent75_100 = (double)count75_100 / numValues * 100;

            Console.WriteLine("Average: " + avg);
            Console.WriteLine("0-25: " + percent0_25 + "%");
            Console.WriteLine("25-50: " + percent25_50 + "%");
            Console.WriteLine("50-75: " + percent50_75 + "%");
            Console.WriteLine("75-100: " + percent75_100 + "%");

            Console.ReadLine();
        }
    }
}