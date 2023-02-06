using CustomThreeuple;

namespace CustomTuple;

class StartUp
{
    public static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        CustomThreeuple<string, string, string> address = new CustomThreeuple<string, string, string>();
        address.Item1 = input1[0] + " " + input1[1];
        address.Item2 = input1[2];
        address.Item3 = input1[3];

        

        string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        CustomThreeuple<string, int, bool> drink = new CustomThreeuple<string, int, bool>();
        drink.Item1 = input2[0];
        drink.Item2 = int.Parse(input2[1]);
        if (input2[2] == "drunk")
        {
            drink.Item3 = true;
        }
        else
        {
            drink.Item3 = false;
        }

        

        string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        CustomThreeuple<string, double, string> numbers = new CustomThreeuple<string, double, string>();
        numbers.Item1 = input3[0];
        numbers.Item2 = double.Parse(input3[1]);
        numbers.Item3 = input3[2];


        Console.WriteLine(address.ToString());
        Console.WriteLine(drink.ToString());
        Console.WriteLine(numbers.ToString());
    }
    
}