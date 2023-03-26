using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String to be reversed");
        string str = Console.ReadLine();
        ReverseStringWithSpaces(str);
        Console.WriteLine();
    }

    static void ReverseStringWithSpaces(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == ' ')
            {
                Console.Write(' ');
            }
            else if (i == 0 || str[i - 1] == ' ')
            {
                Console.Write(str[i]);
            }
            else
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}
