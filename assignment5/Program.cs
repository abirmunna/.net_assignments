using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        string username = "lucas";
        string password = "jamk";
        string inputUsername;
        string inputPassword;

        do
        {
            Console.Write("Enter username: ");
            inputUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            inputPassword = Console.ReadLine();
            attempts++;

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

            if (attempts >= 3)
            {
                Console.WriteLine("Too many attempts. Shutting down.");
                return;
            }

        } while (true);
    }
}
