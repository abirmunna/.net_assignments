using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++) {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = 0;
        foreach (int number in numbers) {
            if (number % 2 == 0) {
                sum += number;
            }
        }

        Console.WriteLine($"Total: {sum}");
    }
}
