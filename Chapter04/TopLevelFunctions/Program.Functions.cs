using static System.Console;
partial class Program
{
    static void WhatsMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}", typeof(Program).Namespace ?? "null");
        
    }
}