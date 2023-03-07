namespace Raiding;

public abstract class BaseHero
{
    public BaseHero(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public int Power { get; set; }

    public abstract string CastAbility();
}
