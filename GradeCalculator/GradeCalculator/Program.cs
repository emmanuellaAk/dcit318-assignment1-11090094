using System;

public class GradeCalculator
{
    public static string CalculateGrade(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    public static void Run()
    {
        try
        {
            Console.Write("Enter your score: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new FormatException("Input cannot be null or empty.");
            }
            int score = int.Parse(input);
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException("Score must be between 0 and 100.");
            }
            string grade = CalculateGrade(score);
            Console.WriteLine($"Your grade is: {grade}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Run();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Run();
        }
    }
    public static void Main(string[] args)
    {
        Run();
    }
}
