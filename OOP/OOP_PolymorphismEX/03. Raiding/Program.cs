namespace Raiding;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<BaseHero> group = new();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();

            switch (type) 
            {
                case "Druid":

                    group.Add(new Druid(name));
                    break;

                case "Paladin":

                    group.Add(new Paladin(name));
                    break;

                case "Rouge":

                    group.Add(new Rouge(name));
                    break;

                case "Warrior":

                    group.Add(new Warrior(name));
                    break;

                default:
                    Console.WriteLine("Invalid hero!");
                    break;
            }
        }

        int bossPower = int.Parse(Console.ReadLine());

        int sumOfPower = group.Sum(x => x.Power);

        foreach (var hero in group)
        {
            Console.WriteLine(hero.CastAbility());
        }

        if (sumOfPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}
