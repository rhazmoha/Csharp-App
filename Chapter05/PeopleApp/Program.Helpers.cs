
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
partial class Program
{


    private static void ConfigureConsole(string culture = "en-US",
                        bool useComputerCulture = false, bool showCulture = true)
    {

        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);

        }

        if (showCulture)
        {
            WriteLine($"Current culture: {CultureInfo.CurrentCulture.DisplayName}.");
        }
    }

    #region  codewars solutions

    public static bool ValidPhoneNumber(string phoneNumber)
    {
        return Regex.IsMatch(phoneNumber, @"^\(\d+\) \d{3}-\d{4}$");
    }

    public static string RemoveUrlAnchor(string url)
    {
        return Regex.Replace(url, @"(?=#).*", "");

    }

    public static string AddBinary(int a, int b)
    {
        return $"{a + b:b}";


    }
    public static string RemoveDuplicateWords(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var seen = new HashSet<string>();
        var result = new List<string>();

        foreach (var word in words)
        {
            if (seen.Add(word))
            {
                result.Add(word);
            }

        }

        return string.Join(' ', result);

    }
    #endregion
}