using System;

public class TicketPriceCalculator
{
    public static int CalculatePrice(int age)
    {
        
        if (age <= 12 || age >= 65)
        {
            return 7;
        }
        else
        {
            return 10;
        }
    }

    public static void Run()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new FormatException("Input cannot be empty.");
                }

                int age = int.Parse(input);

                if (age < 0 || age > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
                }

                int price = CalculatePrice(age);
                Console.WriteLine($"Your ticket price is: GHC{price}");
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Invalid age: {ex.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Run();
    }
}
