

using static System.Console;
using System.Globalization;


/* class Person
{
    public string? FirstName;
    public int Age;

    public DateTime dateOfBirth;

    public Person()
    {

    }

} */

internal class Program
{
    private static void Main(string[] args)
    {

        string applesText = "Apples";
        int applesCount = 1234;
        string bananasText = "Bananas";
        int bananasCount = 56789;

        WriteLine();
        WriteLine($"{"Name",-10}|{"Count",6}");
        WriteLine(new string('-', 20));
        WriteLine($"{applesText,-10}|{applesCount,6:N0}");
        WriteLine($"{bananasText,-10}|{bananasCount,6:N0}");




    }
}