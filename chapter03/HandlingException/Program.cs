using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine(binaryArrayToNumber(new int[] { 0, 1, 0, 1, 0, 1, 0, 1 }));
        

    }

    #region my functions

    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        return Convert.ToInt32(string.Join("", BinaryArray), 2);

    }
    #endregion
}