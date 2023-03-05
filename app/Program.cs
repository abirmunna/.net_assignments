using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assignment 1 Solution");
        Console.Write("Give name ");
        String inp_name = Console.ReadLine();
        GreetPlayer(inp_name);
        Console.WriteLine("");

        Console.WriteLine("Assignment 2 Solution");
        Console.Write("Enter width ");
        int inp_width = int.Parse(Console.ReadLine());

        Console.Write("Enter height ");
        int inp_height = int.Parse(Console.ReadLine());

        int area = CalculateArea(inp_width, inp_height);
        Console.WriteLine("Area for width "+ inp_width +" and height "+ inp_height +" is "+ area);
        Console.WriteLine("");

        
        Console.WriteLine("Assignment 3 Solution");
        int value = RequestValue();
        bool isEven = IsEven(value);
        PrintResult(isEven, value);

        value = RequestValue();
        isEven = IsEven(value);
        PrintResult(isEven, value);

        value = RequestValue();
        isEven = IsEven(value);
        PrintResult(isEven, value);
        Console.WriteLine("");

        Console.WriteLine("Assignment 4 Solution");
        Console.Write("Give height  ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Give radius ");
        double radius = double.Parse(Console.ReadLine());

        double volume = CalculateCylinderVolume(height, radius);
        Console.WriteLine($"{volume.ToString("0.0000")}cm3");
        Console.WriteLine("");

        Console.WriteLine("Assignment 5 Solution");
        
        Console.Write("Type 1 for radius, 2 for diameter, 3 for circumference: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Height ");
                height = double.Parse(Console.ReadLine());
                Console.Write("Radius ");
                radius = double.Parse(Console.ReadLine());
                break;
            case 2:
                Console.Write("Height ");
                height = double.Parse(Console.ReadLine());
                Console.Write("Diameter ");
                double diameter = double.Parse(Console.ReadLine());
                radius = diameter / 2.0;
                break;
            case 3:
                Console.Write("Height ");
                height = double.Parse(Console.ReadLine());
                Console.Write("Circumference ");
                double circumference = double.Parse(Console.ReadLine());
                volume = CalculateCylinderVolumeFromCircumference(height, circumference);
                Console.WriteLine($"Volume is {volume.ToString("0.0000")}cm3");
                Console.WriteLine("");
                // radius = circumference / (2.0 * Math.PI);
                return;
            default:
                Console.WriteLine("Wrong info, Closing application");
                return;
        }

        volume = CalculateCylinderVolume(radius, height);
        Console.WriteLine($"Volume is {volume.ToString("0.0000")}cm3");
        Console.WriteLine("");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public static void GreetPlayer(string name)
    {
        Console.WriteLine("Welcome " + name);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }


    static int RequestValue()
    {
        Console.Write("Enter a value: ");
        return int.Parse(Console.ReadLine());
    }

    static bool IsEven(int value)
    {
        return value % 2 == 0;
    }

    static void PrintResult(bool isEven, int value)
    {
        if (isEven)
        {
            Console.WriteLine($"{value} is even");
        }
        else
        {
            Console.WriteLine($"{value} is odd");
        }
    }
    static double CalculateCylinderVolume(double height, double radius)
    {
        double volume = Math.PI * Math.Pow(radius, 2) * height;

        return volume;
    }
    static double CalculateCylinderVolumeFromCircumference(double height, double circumference)
    {
        double radius = circumference / (2.0 * Math.PI);
        double volume = Math.Pow(radius, 2) * Math.PI * height;
        return volume;
    }
}
