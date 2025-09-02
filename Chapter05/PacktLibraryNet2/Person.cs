using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class Person : object
{
    #region  Fields: Data or state for this person.
    public string? Name;
    public DateTimeOffset Born;


    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;


    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public const string Species = "human";

    #endregion

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;

    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #region  Actions the type can perform.

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {

        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }
    #endregion

}