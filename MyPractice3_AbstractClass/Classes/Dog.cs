// Implement an abstract class with a concrete class.
class Dog : Animal
{
    public override void Voice()
    {
        Console.WriteLine("Voice in Dog style");
    }

    public override void Move()
    {
        Console.WriteLine("Run in Dog style");
    }

}

