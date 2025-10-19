using System.Reflection.Metadata.Ecma335;

var rectangle1 = new Rectangle(10, 5);
var calculator = new ShapeMeasurementsCalculator();
System.Console.WriteLine($"Width is: {rectangle1.Width}");
System.Console.WriteLine($"height is: {rectangle1.Height}");
System.Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
System.Console.WriteLine($"Perimiter is {calculator.CalculateRectanglePerimiter(rectangle1)}");


class Rectangle
{
    public int Width = 3;
    public int Height = 4;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

   public int CalculatePerimiter()
    {
        return 2 * Width + 2 * Height;
    }

   public int CalcultateArea()
    {
        return Width * Height;
    }

}

class ShapeMeasurementsCalculator
{
    public int CalculateRectanglePerimiter(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}
class HotelBooking
{
    public string GuestName;

    public DateTime StartDate;

    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);

    }
}

class Triangle
{
    private int _base;

    private int _height;

    public Triangle(int @base, int height)
    {
        _base = @base;
        _height = height;
    }

    public int CalculateArea()
    {
        return (_base * _height) / 2;
    }

    public string AsString()
    {
       return $"Base is {_base}, Height is {_height}";
    }

}