using System;
using System.Text.RegularExpressions;
using static System.Console;
using System.Threading.Tasks;
using System.IO;


class Program
{

    static void Main()
    {
        try
        {
           

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

    async static Task<string> DoTask()
    {
        await Task.Delay(5000);
        string output = "";

        output = File.ReadAllText("contenu.txt");
        return output;
    }

    
}


