using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words one at a time, enter q to quit and print ");
        string sentence = "";
        bool isFirstWord = true;

        while (true)
        {
            string word = Console.ReadLine();

            if (word == "q")
            {
                break;
            }

            if (isFirstWord)
            {
                sentence += word;
                isFirstWord = false;
            }
            else
            {
                sentence += " " + word;
            }
        }

        Console.WriteLine(sentence);
    }
}
