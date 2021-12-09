// Implement an abstract class with a concrete class.
class Bird : Animal
{
    public override void Voice()
    {
        Console.WriteLine("Voice in Bird style");
    }

    public override void Move()
    {
        Console.WriteLine("Fly in Bird style");
    }
}
