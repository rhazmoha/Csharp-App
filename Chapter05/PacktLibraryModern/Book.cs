using System.Diagnostics.CodeAnalysis;


namespace Packt.Shared;

public class Book
{
    #region  fileds of my class
    public required string? Isbn;
    public required string? Title;

    public string? Author;
    public int PageCount;

    #endregion

    public Book() { }

    [SetsRequiredMembers]
    public Book(string isbn, string title)
    {
        Isbn = isbn;
        Title = title;

    }


}
