using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string output = ProcessString(input);
        Console.WriteLine(output);
    }

    public static string ProcessString(string input)
    {
        string output = input;
        int index = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                index = i + 1;
                break;
            }
        }
        if (index != 0)
        {
            output = input.Substring(0, index).ToUpper(); 
        }
        else
        {
            output = input.ToUpper(); 
        }
        return output;
    }
}
