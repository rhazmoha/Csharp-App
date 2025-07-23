using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;
using System.Linq;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Write("How many eggs are there? ");
        string? input = ReadLine();

        if (int.TryParse(input, out int count))
        {
            WriteLine($"There are {count} eggs.");
        }
        else
        {
            WriteLine("I could not parse the input.");
        }


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

    public static string Maskify(string cc)
    {
        int charsNum = cc.Length;

        if (charsNum > 4)
        {
            string hashes = new string('#', charsNum - 4);

            return hashes + cc.Substring(charsNum - 4);
        }

        return cc;
    }
    public static int FindShort(string s)
    {
        string[] words = s.Split(new char[] { ' ' });


        var lengths = words.Select(word => word.Length);

        return lengths.Min();
    }
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