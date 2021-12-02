#region Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создайте класс AbstractHandler. 
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса 
//AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны 
//быть методы открытия, создания, редактирования, сохранения определенного формата документа. 
#endregion

// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Abstract classes - a class of abstract methods and concrete methods.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).

// Create an object of the XMLHandler class and cast it
// to the abstract class AbstractHandler
// implementation of methods of the XMLHandler child class.
AbstractHandler doc1 = new XMLHandler();

// Create an object of TXTHandler class and cast it
// to the abstract class AbstractHandler
// implementation of methods of the TXTHandler child class.
AbstractHandler doc2 = new TXTHandler();

// Create an object of the DOCHandler class and cast it
// to the abstract class AbstractHandler
// implementation of methods of the child class DOCHandler.
AbstractHandler doc3 = new DOCHandler();

// Using overridden methods of the XMLHandler child class.
doc1.ShowClassMethods();

// Using overridden methods of the TXTHandler child class.
doc2.ShowClassMethods();

// Using overridden methods of the child class DOCHandler.
doc3.ShowClassMethods();

// Delay.
Console.ReadKey();
