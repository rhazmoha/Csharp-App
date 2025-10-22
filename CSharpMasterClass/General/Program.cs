


//var rectangle1 = new Rectangle(10, 5);
//var calculator = new ShapeMeasurementsCalculator();
//System.Console.WriteLine($"Width is: {rectangle1.Width}");
//System.Console.WriteLine($"height is: {rectangle1.Height}");
//System.Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
//System.Console.WriteLine($"Perimiter is {calculator.CalculateRectanglePerimiter(rectangle1)}");

var rect = new Rectangle(10, 12);


class MedicalAppointmentPinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        System.Console.WriteLine($"Appointment will take place on {medicalAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName) :
    this(patientName, 7)
    {

    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public DateTime GetDate() => _date;
    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPinter();
        printer.Print(this);
    }

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
}

class Rectangle
{
    public const int NumberOfSides = 4;
    public readonly int NumberOfSidesReadOnly = 4;
    public readonly int Width;
    private  int _height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));


    }

   public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value >= 0)
        {
            _height = value;
        }
    }
    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaulValueIfNonPositive = 1;


        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number");
            return DefaulValueIfNonPositive;
        }

        return length;

    }

    public int CalculatePerimiter() => 2 * Width + 2 * _height;




    public int CalcultateArea() => Width * _height;




}

class ShapeMeasurementsCalculator
{
    public int CalculateRectanglePerimiter(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle._height;
    }

    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle._height;
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

public class Dog
{
    private string _name;
    private string _breed;

    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
        _name = name;
        _weight = weight;

    }

    public string Describe()
    {
        string size;

        if (_weight > 30)
        {
            size = "large";
        }
        else if (_weight >= 5)
        {
            size = "medium";
        }
        else
        {
            size = "tiny";
        }


        return $"This dog is named {_name}, it's {_breed}, and it weighs {_weight}, so it's a {size} dog";
    }




}