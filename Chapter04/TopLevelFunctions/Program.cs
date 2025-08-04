using System.ComponentModel;
using System.Threading.Tasks;
using static System.Console;
using CallStackExceptionHandlingLib;

partial class Program
{
    static void Main(string[] args)
    {
        WriteLine(RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"));
        
    }

    static void Alpha()
    {
        WriteLine("In Alpha");
        Beta();
    }

    private static void Beta()
    {
        WriteLine("In Beta");
        try
        {
            Processor.Gamma();
        }
        catch (Exception ex)
        {
            WriteLine($"Caught this: {ex.Message}, type : {ex.GetType()}");
            throw;
        }
        
    }
}










