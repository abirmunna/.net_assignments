using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[10];
        Random rand = new Random();

        // Fill array with random numbers
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rand.Next();
        }

        // Sort array in ascending order
        Array.Sort(arr);

        // Print sorted array
        foreach (int num in arr) {
            Console.WriteLine(num);
        }
    }
}
