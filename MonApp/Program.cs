using System;
using System.Text.RegularExpressions;
using static System.Console;


class Program
{
    static void Main()
    {
        try
        {
            string input = "before <b>first before</b> before <b>before before</b>";
            string outerPattern = @"<b>.*?</b>";
            var outerRegex = new Regex(outerPattern, RegexOptions.Singleline);

            string result = outerRegex.Replace(input, MatchReplace);
        
            WriteLine(result);


        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);

        }

    }

    static string MatchReplace(Match match)
    {
        string innerPattern = @"before";
        var innerRegex = new Regex(innerPattern);

        return innerRegex.Replace(match.Value, @"after");


    }
}


