using System;

public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine("Hi {0}, I'm {1}", to, Name);
    }

    public static Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;
        return person;
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        
        var result = int.TryParse("569", out int number);
      string x =  result ? number.ToString() : "failed";

    }

    static void UseParams()
    {
        var calc = new Calculator();
        System.Console.WriteLine(calc.Add(new int[] {1,5,6,8}));
    }

    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 20);
            point.Move(null);

            System.Console.WriteLine("point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            System.Console.WriteLine("point is at ({0}, {1})", point.X, point.Y);
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("an unexpected error occured");
        }
    }
}