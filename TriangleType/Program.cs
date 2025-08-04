using System;

public class TriangleTypeIdentifier
{
    public static string IdentifyTriangleType(double side1, double side2, double side3)
    {
        
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            return "Not a valid triangle ";
        }

        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }

    public static void Run()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter side 1: ");
                string? input1 = Console.ReadLine();
                Console.Write("Enter side 2: ");
                string? input2 = Console.ReadLine();
                Console.Write("Enter side 3: ");
                string? input3 = Console.ReadLine();

                if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3))
                {
                    throw new FormatException("All sides must be entered.");
                }

                double side1 = double.Parse(input1);
                double side2 = double.Parse(input2);
                double side3 = double.Parse(input3);

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentOutOfRangeException("Sides must be positive numbers.");
                }

                string triangleType = IdentifyTriangleType(side1, side2, side3);
                Console.WriteLine($"Triangle type: {triangleType}");
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Invalid side length: {ex.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Run();
    }
}
