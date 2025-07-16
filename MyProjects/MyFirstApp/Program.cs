

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

        int[] nums = { 1, 5, 4, 7, 4, 9, 8 };
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                WriteLine(num);
            }
        }
    }
}