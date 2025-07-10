using System.Text.RegularExpressions;
class LogLine
{
    public static string Message(string logLine)
    {
        int messageStart = logLine.IndexOf(':');
        string message = logLine.Substring(messageStart + 1);

        return message.Trim();

    }

    public static string LogLevel(string logLine)
    {
        string pattern = @"\[([a-z]+)\]";
        var match = Regex.Match(logLine, pattern, RegexOptions.IgnoreCase);
        if (match.Success)
        {
            return match.Groups[1].Value.ToLower();
        }

        return "";
        

    }

    public static string Reformat(string logLine)
    {
        string output = $"{Message(logLine)} ({LogLevel(logLine)})";
        return output;
    }
}