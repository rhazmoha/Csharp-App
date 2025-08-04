using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(1,2,3)]
    public void TestAdding(double a, double b, double expected)
    {
        Calculator calc = new();

        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdding2And2()
    {
        double a = 2;
        double b = 2;
        double expected = 4;

        Calculator calc = new();

        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);


    }
    
    [Fact]
    public void TestAdding2And3()
    {
        double a = 2;
        double b = 3;
        double expected = 5;

        Calculator calc = new();
        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);


    }
}