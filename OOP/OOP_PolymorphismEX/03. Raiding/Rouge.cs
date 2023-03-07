namespace Raiding;

public class Rouge : BaseHero
{
    public Rouge(string name) : base(name)
    {
        Power = 80;
    }

    public override string CastAbility()
    {
        return $"Rouge - {Name} hit for {Power} damage";
    }
}
