using System.ComponentModel;
using System.Threading.Tasks;
using static System.Console;

partial class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            WriteLine("goodbye hot reload!");
            await Task.Delay(2000);
        }
        
    }
}










