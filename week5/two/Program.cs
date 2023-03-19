using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        const int MAX_NAMES = 5;
        List<string> names = new List<string>();

        while (names.Count < MAX_NAMES) {
            Console.Write($"Give a name or type q to quit \n");
            string input = Console.ReadLine();

            if (input == "q") {
                Console.WriteLine("Quitting program.");
                break;
            }

            if (names.Contains(input)) {
                Console.WriteLine("The name already exists in the list.");
                continue;
            }

            names.Add(input);

            if (names.Count == MAX_NAMES) {
                Console.WriteLine("Maximum number of names reached.");
            }
        }

        names.Sort();
        Console.WriteLine("Sorted names:");
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }
}
