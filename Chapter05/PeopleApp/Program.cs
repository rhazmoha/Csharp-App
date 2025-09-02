// See https://aka.ms/new-console-template for more information
using Packt.Shared;
using Env = System.Environment;

ConfigureConsole(culture: "en-USA");

Person bob = new();
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(1965, 12, 22,
                            16, 28, 0, TimeSpan.FromHours(-5));

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;


WriteLine("{0} was born on {1:D}", bob.Name, bob.Born);
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.", bob.Name, bob.FavoriteAncientWonder, (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
 // This is an optional offset from UTC time zone.
 TimeSpan.Zero)
};

WriteLine($"{alice.Name} was born on {alice.Born:d}");

Person alfred = new Person();
alfred.Name = "alfred";
bob.Children.Add(alfred);

bob.Children.Add(new Person { Name = "bella" });

bob.Children.Add(new() { Name = "zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children");

foreach (var child in bob.Children)
{
    WriteLine($"> {child.Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs jones";
jonesAccount.Balance = 2400M;

WriteLine("{0} earned {1:C} interest.", jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
 arg0: gerrierAccount.AccountName,
 arg1: gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");
uint m = 0x8000_0000;
WriteLine($"int.MinValue : {int.MinValue}, m {m}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

/*Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new Book(isbn: "978-1803237800",
title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};



WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
 book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();
WriteLine(format:
 "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
 arg0: blankPerson.Name,
 arg1: blankPerson.HomePlanet,
 arg2: blankPerson.Instantiated);

Person gunny = new Person(initialName: "Gunny", homePlanet: "Mars");

WriteLine(format:
 "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
 arg0: gunny.Name,
 arg1: gunny.HomePlanet,
 arg2: gunny.Instantiated);


bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));













