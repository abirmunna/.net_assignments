using System;

class Program
{
    static void Main(string[] args)
    {
        string sentence = "The quick brown fox jumps over the lazy dog";

        while (true)
        {
            Console.WriteLine("Enter letter to find in The quick brown fox jumps over the lazy dog");
            string letter = Console.ReadLine();

            if (letter.Length > 1)
            {
                Console.WriteLine("End of program");
                break;
            }

            Console.WriteLine("Matching words" + letter);

            foreach (string word in sentence.Split(' '))
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
