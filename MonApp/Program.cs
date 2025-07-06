using System;
using System.Text.RegularExpressions;
using static System.Console;


class Program
{
     
    static void Main()
    {
        try
        {
            string input = @"<b>I●like●<b><b>bold</b>●and <i>italic</i>●fonts<b>";

            string pattern = @"<[^<>]*>";

            string[] spliArray = new Regex(pattern).Split(input);

            Array.ForEach(spliArray, item => WriteLine(item));
            



        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);

        }

    }

    static string MatchReplace(Match match)
    {
        return "match";

    }
}


