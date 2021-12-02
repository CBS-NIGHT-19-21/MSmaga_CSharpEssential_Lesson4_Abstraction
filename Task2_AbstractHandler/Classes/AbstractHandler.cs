// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Abstract classes - a class of abstract methods and concrete methods.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).

// Create an abstract class AbstractHandler to declare abstract methods
// and then override these methods in child classes.
abstract class AbstractHandler
{
    // Declarations of abstract methods.
    public abstract void Open();

    public abstract void Create();

    public abstract void Change();

    public abstract void Save();

    // Declarations method outputs the name of the class and how methods work.
    public void ShowClassMethods()
    {
        Console.WriteLine("{0}:\n", this.GetType());

        Open();

        Create();

        Change();

        Save();

        Console.WriteLine();
    }
}
