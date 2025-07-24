using static System.Console;
partial class Program
{
    static void WhatsMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}", typeof(Program).Namespace ?? "null");

    }

    static void Times(int number, int size)
    {
        WriteLine($"Times table of {number}");
        for (int i = 1; i <= size; i++)
        {
            WriteLine($"{i,-2} x {number,-2} = {i * number}");
        }
        
    }
}