using System.Xml;
using static System.Console;


class Person
{
    public string? FirstName;
    public int Age;

    public Person()
    {
        
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        Person p = new();
        WriteLine($"{p.Age}");



    }
}