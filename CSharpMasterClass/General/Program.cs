var rectangle1 = new Rectangle(10,5);
System.Console.WriteLine($"Width is: {rectangle1.Width}");
System.Console.WriteLine($"height is: {rectangle1.Height}");


class Rectangle
{
    public int Width = 3;
    public int Height = 4;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
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