// Implement an abstract class with a concrete class.

class Fish : Animal
{
    public override void Voice()
    {
        Console.WriteLine("Voice in Fish style");
    }

    public override void Move()
    {
        Console.WriteLine("Swim in Fish style");
    }
}

