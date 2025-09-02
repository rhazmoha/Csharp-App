using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class Person : object
{
    #region  Fields: Data or state for this person.
    public string? Name;
    public DateTimeOffset Born ;

  
    public readonly string HomePlanet = "Earth";

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public const string Species = "human";
    
    #endregion

    public Person()
    {


    }

}