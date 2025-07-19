class Animal
{
    public string? Name;
    public DateTime Born;
    public byte Legs;

}

class Cat : Animal
{
    public bool IsDomestic;
}

class Spider : Animal // This is another subtype of animal.
{
 public bool IsVenomous;
}