using System;

public class Rectangle {
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle() {
        
    }

    public int GetArea() {
        return Length * Width;
    }
}

public class Program {
    static void Main() {
        Rectangle[] rectangles = new Rectangle[5];

        Random random = new Random();
        for (int i = 0; i < rectangles.Length; i++) {
            rectangles[i] = new Rectangle {
                Length = random.Next(1, 11),
                Width = random.Next(1, 11)
            };
            Console.WriteLine($"Rectangle {i+1} has width {rectangles[i].Width} and length {rectangles[i].Length}");
        }

        Console.WriteLine();
        foreach (Rectangle rectangle in rectangles) {
            int area = rectangle.GetArea();
            Console.WriteLine(area);
        }
    }
}
