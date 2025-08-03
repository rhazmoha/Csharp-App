using static System.Console;
using System.Globalization;
partial class Program
{


    static double Add(double a, double b)
    {
        return a * b;
    }
    static void RunFactorial()
    {
        for (int i = 1; i <= 202; i += 100)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");

            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }

    }
    static int FactorialLoop(int number)
    {
        int result = 1;

        while (number > 0)
        {
            result *= number;
            number--;
        }

        return result;

    }



    static double Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), $"The factorial function is defined for non-negative integers only. Input: {number}");

        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }


    }

    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");

        }

        WriteLine();
    }

    /// <summary>
    /// Pass a 32-bit unsigned integer and it will be converted into its
    ///ordinal equivalent
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";

            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }
    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        //  OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }

        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");


    }
    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M,
        };

        return rate * amount;



    }


    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }

        WriteLine();
    }


}