// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Abstract classes - a class of abstract methods and concrete methods.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).

// Create a concrete child XMLHandler class
// from parent abstract class AbstractHandler
// and override these methods of the parent class AbstractHandler.
class XMLHandler : AbstractHandler
{
    // Override - overriding methods.
    public override void Open()
    {
        Console.WriteLine(" Open XML document ");
    }

    public override void Create()
    {
        Console.WriteLine(" Create XML document ");
    }

    public override void Change()
    {
        Console.WriteLine(" Change XML document ");
    }

    public override void Save()
    {
        Console.WriteLine(" Save XML document ");
    }
}
