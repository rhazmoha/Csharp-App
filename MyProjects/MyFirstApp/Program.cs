

using static System.Console;
using System.Globalization;


class Person
{
    public string? FirstName;
    public int Age;

    public DateTime DateOfBirth;

    public Person(string firstName, int age, DateTime dateOfBirth)
    {
        FirstName = firstName;
        Age = age;
        DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"{this.FirstName} has {this.Age} and his date of birth {this.DateOfBirth:dd/MM/yyyy}";
    }

}

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Type your first name and press ENTER: ");
        string? firstName = ReadLine();

        Console.Write("Type your age and press ENTER: ");
        string age = ReadLine()!;

        Console.WriteLine($"Hello {firstName}, you look good for {age}.");
    }
}