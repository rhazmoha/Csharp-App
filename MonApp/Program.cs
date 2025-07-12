using System;
using System.Text.RegularExpressions;
using static System.Console;
using System.Threading.Tasks;
using System.IO;

namespace MonApp
{
    class Program
    {

        static void Main()
        {

            WriteLine(Environment.CurrentDirectory);
            WriteLine(Environment.OSVersion.VersionString);

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

}
