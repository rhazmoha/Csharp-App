internal class Program
{
    private static void Main(string[] args)
    {
        #region Exploring unary operators

        int a = 3, b;

        b = a++;
        WriteLine($"a is {a}, b is {b}");

        int c = 3;
        int d = ++c; // Prefix means increment c before assigning it.
        WriteLine($"c is {c}, d is {d}");

        #endregion
    }
}