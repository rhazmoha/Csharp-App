using System.Reflection.Emit;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {

        var animals = new Animal?[]{
            new Cat {Name = "Karen", Born = new DateTime(2022,8,23),
            Legs = 4, IsDomestic =true },
            null,
            new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6,
 day: 12) },
 new Spider { Name = "Sid Vicious", Born = DateTime.Today,
 IsVenomous = true},
 new Spider { Name = "Captain Furry", Born = DateTime.Today } };

        object message = null;

        string answer = message switch
        {
            string s when s == "a" => "string a",
            int i when i == 10 => "int 10",
            _ => "no value"
        };

        WriteLine(answer);







    }

    #region my functions
    public static int? ToCents(string price)
    {
        string pattern = @"^\$\d+\.\d{2}$";

        var match = Regex.Match(price, pattern);
        if (match.Success)
        {
            string centsStr = Regex.Replace(match.Value, @"[$.]", "");
            return int.Parse(centsStr);
        }
        else
        {
            return null;
        }


    }
    #endregion
}