namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(4);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine(circle.Draw());
        Console.WriteLine(rectangle.Draw());
    }
}
