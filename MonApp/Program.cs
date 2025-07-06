using System;
using System.Text.RegularExpressions;
using static System.Console;


class Program
{
    static void Main()
    {
        try
        {

            string pattern = @"\d+";
            string input = "10 100 1000 kjkfglk 50 99";

            string result = Regex.Replace(input, pattern, new MatchEvaluator(MatchReplace));

            WriteLine(result);

        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);

        }

    }
    
    static string MatchReplace(Match match) {
        //convertir le match en nombre
        int num = int.Parse(match.Value);

        num *= 2;

        return num.ToString();

    }
}


