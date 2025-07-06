using System;
using System.Text.RegularExpressions;
using static System.Console;


class Program
{
    static string input = @" ""text"" <span class=""middle"">""text""</span>";
    static void Main()
    {
        try
        {


            string outerPettern = @"""(\w+)""";

            string result = Regex.Replace(input, outerPettern, MatchReplace);

            WriteLine(result);


        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);

        }

    }

    static string MatchReplace(Match match)
    {
        string innerPattern = @$"(?<=<.*){match.Value}(?=.*>)";

        bool ismatch = Regex.IsMatch(input, innerPattern);

        if (ismatch)
        {
            return match.Value;
        }
        else
        {
            return $"*{match.Groups[1].Value}*";
        }



    }
}


