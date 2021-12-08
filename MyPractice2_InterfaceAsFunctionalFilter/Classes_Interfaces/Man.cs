class Man : IHusband, IWorker, IFriend
{
    // Implementation class semantic - method functional of Interface Husband.

    public void WatchTV()
    {
        Console.WriteLine("I`m watching the TV.");
    }
    public void CutGrass()
    {
        Console.WriteLine("I`m cuttiing the grass.");
    }

    // Implementation class semantic - method functional of Interface IWorker.
    public void Work()
    {
        Console.WriteLine("I`m working now.");
    }
    public void CreateReport()
    {
        Console.WriteLine("I`m creating the report.");
    }

    // Implementation class semantic - method functional of Interface IFriend.
    public void Advice()
    {
        Console.WriteLine("I advice you.");
    }
    public void DrinkBeer()
    {
        Console.WriteLine("I`m drinking the beer.");
    }
}

