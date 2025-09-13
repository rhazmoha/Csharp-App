using System;

public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine("Hi {0}, I'm {1}", to, Name);
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        int i = 123;
        Console.WriteLine(i.ToString("b"));

    }
}