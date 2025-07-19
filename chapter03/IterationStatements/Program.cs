using System.Diagnostics;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (long y = 0; y < long.MaxValue; y++)
        {

        }
        var time = stopWatch.Elapsed;
        WriteLine($"end of program in {time.Milliseconds} ms");
        
    }
}