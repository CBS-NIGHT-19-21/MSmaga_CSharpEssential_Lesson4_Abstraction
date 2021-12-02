#region Задание Дополнительное
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: Изменить 12 пример первого урока (работа с документом) и создать общий абстрактный 
//класс для всех частей документа.
#endregion

using System;
// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Composition : Association.
// Declarate class of this kind of objects as a mandatory member - a field of another class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Abstract classes - a class of abstract methods and concrete methods.

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта...";

            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
