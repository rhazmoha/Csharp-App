// See https://aka.ms/new-console-template for more information
using Packt.Shared;
using Env = System.Environment;

ConfigureConsole(culture: "fr-MA");

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








