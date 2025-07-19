using System.Text.RegularExpressions;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {


        WriteLine(CreatePhoneNumber(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));


    }

    #region my functions
    public static string CreatePhoneNumber(int[] numbers)
    {
        string phoneNumber = "";
        foreach (int digit in numbers)
        {
            phoneNumber += digit.ToString();
        }

        phoneNumber = Regex.Replace(phoneNumber, @"(\d{3})(\d{3})(\d{4})", @"(${1}) ${2}-${3}");
        return phoneNumber;


    }
    #endregion
}

class Car
{
    public string? Model;
}