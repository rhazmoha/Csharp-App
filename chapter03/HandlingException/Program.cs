using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Before parsing");
        Write("What is your age? ");
        string? input = ReadLine();

        /* if (input is null)
        {
            WriteLine("You did not enter a value so the app has ended.");
            return; // Exit the app.
        } */

        try
        {
            int age = int.Parse(input!);
            WriteLine($"You are {age} years old.");
        }
        catch
        {
            
        }
        WriteLine("After parsing");


    }
}