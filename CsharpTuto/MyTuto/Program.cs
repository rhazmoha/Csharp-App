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
        var customer = new Customer() { Id = 2, Name = "jack" };
       // customer.Id = 1;
       // customer.Name = "john";
        
        System.Console.WriteLine(customer.Name);

        
        


    }
}