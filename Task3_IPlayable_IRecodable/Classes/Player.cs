// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields

// Interface is a class without fields, has only methods, namely abstract ones, 
// is a filter or extension of the functionality of the class methods, 
// which must be implemented in child classes using override overrides.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).


// Create Player class from IPlayable, IRecodable interfaces.
class Player : IPlayable, IRecodable
{
    // Definition of methods - operations of the Player class.
    public void Play()
    {
        Console.WriteLine("It is playing!");
    }

    public void Record()
    {
        Console.WriteLine("It is recording!");
    }

    public void Stop()
    {
        Console.WriteLine("It is stopped!");
    }

    public void Pause()
    {
        Console.WriteLine("It is paused!");
    }
}
