class Program
{
    private static int RequestValue(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }
    
    private static float CalculateWithRadius(int height, float radius) 
    {
        return height * (float)Math.PI * (float)Math.Pow(radius, 2f);
    }
    
    private static float CalculateWithDiameter(int height, int diameter) 
    {
        return CalculateWithRadius(height, diameter / 2f);
    }
    
    private static float CalculateWithCircumference(int height, float circumference)
    {
        float twoPI = 2f * (float)Math.PI; 
        return CalculateWithRadius(height, circumference / twoPI);
    }
    
    private static int RequestChoice() 
    {
        string value = "Type 1 for radius, type 2 for diameter, type 3 for circumference: ";
        return RequestValue(value);
    }
    
    static void Main(string[] args) 
    {
        bool validEntry;
        do
        {
            validEntry = true; 
            int result = RequestChoice();
            int height = 0, other = 0;
            float volume = 0;
            
            switch (result) 
            {
                case 1:
                    height = RequestValue("Height ");
                    other = RequestValue("Radius ");
                    volume = CalculateWithRadius(height, other);
                    break;
                case 2:
                    height = RequestValue("Height ");
                    other = RequestValue("Diameter ");
                    volume = CalculateWithDiameter(height, other);
                    break;
                case 3:
                    height = RequestValue("Height ");
                    other = RequestValue("Circumference ");
                    volume = CalculateWithCircumference(height, other);
                    break;
                default:
                    Console.WriteLine("Wrong info, closing application");
                    validEntry = false;
                    break;
            }
            
            if (validEntry)
            {
                Console.WriteLine("Volume is " + volume + "cm3");
                Console.ReadLine();
            }
            
        } while (validEntry);
    }
}