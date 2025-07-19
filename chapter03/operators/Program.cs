using System.Text;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        

    }

    #region my functions

    public static bool Vowel(string s)
    {

        return Regex.IsMatch(s, @"^[aeiou]\z", RegexOptions.IgnoreCase);


    }

    public static string Explode(string s)
    {
        /* string newStr = Regex.Replace(s, @"\d", match =>
        {
            int digit = int.Parse(match.Value);
            return new string(match.Value[0], digit);

        });

        return newStr; */

        StringBuilder sb = new();

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                int i = int.Parse(c.ToString());
                sb.Append(new string(c, i));

            }
            else
            {
                sb.Append(c);
            }

        }

        return sb.ToString();
    }

    public static string Remove(string s)
    {
        string pattern = @"!+(?= |$)";
        return Regex.Replace(s, pattern, "");

    }



    static bool IsUpperCase(string text)
    {
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                if (char.IsLower(c))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool DoStuff()
    {
        WriteLine("I am doing some stuff.");
        return true;
    }

    #endregion
}