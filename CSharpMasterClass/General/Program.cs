using System.Reflection.Metadata.Ecma335;

var rectangle1 = new Rectangle(10, 5);
var calculator = new ShapeMeasurementsCalculator();
System.Console.WriteLine($"Width is: {rectangle1.Width}");
System.Console.WriteLine($"height is: {rectangle1.Height}");
System.Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
System.Console.WriteLine($"Perimiter is {calculator.CalculateRectanglePerimiter(rectangle1)}");

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
    public int Width = 3;
    public int Height = 4;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int CalculatePerimiter() => 2 * Width + 2 * Height;
    
        
    

    public int CalcultateArea() => Width * Height;
    
        
    

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