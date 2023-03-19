using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        Random random = new Random();
        for (int i = 0; i < 100; i++) {
            int value = random.Next(1, 11);

            if (counts.ContainsKey(value)) {
                counts[value]++;
            } else {
                counts[value] = 1;
            }
        }

       
        foreach (KeyValuePair<int, int> count in counts) {
            Console.WriteLine($"Number: {count.Key} was generated {count.Value} times");
        }
    }
}
