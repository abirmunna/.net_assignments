using System;

class Program
{
    static void Main(string[] args)
    {
        string dateStr = "05/01/2008 8:30:52 AM";
        string[] dateParts = dateStr.Split(' ');
        string[] date = dateParts[0].Split('/');
        string[] time = dateParts[1].Split(':');
        int hour = int.Parse(time[0]);
        bool isAM = dateParts[2] == "AM";



        while (true)
        {
            Console.WriteLine("1 - Full date\n2 - Day\n3 - Month\n4 - Year");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 4 || input < 1)
            {
                break;
            }
            else if (input == 1)
            {
                Console.WriteLine(date[0] + "/" + date[1] + "/" + date[2]);
            }
            else if (input == 2)
            {
                Console.WriteLine(date[0]);
            }
            else if (input == 3)
            {
                Console.WriteLine(date[1]);
            }
            else if (input == 4)
            {
                Console.WriteLine(date[2]);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
