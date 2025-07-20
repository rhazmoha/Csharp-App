using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;
internal class Program
{
    private static void Main(string[] args)
    {

        WriteLine($"{LowercaseCountCheck("abcABC123")}");
        







    }

    static string CheckSwitch(int[] values) => values switch
    {
        [] => "empty array",
        [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
        [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
        [1, 2] => "Contains 1 then 2.",
        [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
        [0, _] => "Starts with 0, then one other number.",
        [0, ..] => "Starts with 0, then any range of numbers.",
        [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
        [..] => "Any items in any order.",

    };


    #region my functions

    public static int LowercaseCountCheck(string s)
    {
        return Regex.Matches(s, @"[a-z]").Count;
        
  }
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