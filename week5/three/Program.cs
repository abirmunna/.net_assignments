using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Dictionary<string, int> people = new Dictionary<string, int>();

        Console.WriteLine("Enter names and ages (or enter q to finish):");
        while (true) {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name == "q") {
                break;
            }

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            people[name] = age;
        }

        Console.WriteLine("\nAll entries:");
        foreach (KeyValuePair<string, int> person in people) {
            Console.WriteLine($"{person.Key}: {person.Value} years old");
        }

        Console.WriteLine("\nPeople under 25 years old:");
        foreach (KeyValuePair<string, int> person in people) {
            if (person.Value < 25) {
                Console.WriteLine($"{person.Key}: {person.Value} years old");
            }
        }
    }
}
