using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine($"{IsUpperCase("HELL11O")}");

    }

    static bool IsUpperCase(string text)
    {
        
        return !Regex.IsMatch(text, @"[a-z]");
        

    }


    /* static bool IsUpperCase(string text)
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
 */
    static bool DoStuff()
    {
        WriteLine("I am doing some stuff.");
        return true;
    }
}