namespace Task3_IPlayable_IRecodable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Требуется: 
            //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
            //Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
            //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
            //Написать программу, которая выполняет проигрывание и запись. 
            #endregion

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


            // Create an object of the Player class and cast it to a child
            // to the IPlayable interface from the parent IDevice.
            IPlayable player1 = new Player();

            Console.WriteLine("IPlayable:");
            // Call the Play () method declared in the child interface IPlayable
            // parent interface IDevice.
            player1.Play();

            // Call the Pause (), Stop () method declared in
            // parent interface IDevice.
            player1.Pause();

            player1.Stop();

            Console.WriteLine();
            // Calling the Record () method is not available because
            // declared in interface IRecodable from parent IDevice

            // Create an object of the Player class and cast it to a child
            // to the IRecodable interface from the parent IDevice.
            IRecodable player2 = new Player();

            Console.WriteLine("IRecodable:");

            // Call the Record () method declared in the child interface IRecodable
            // parent interface IDevice.
            player2.Record();

            // Call the Pause (), Stop () method declared in
            // parent interface IDevice.
            player2.Pause();

            player2.Stop();

            // Call of the Play () method is not available because
            // declared in interface IPlayable from parent IDevice.

            //Delay.
            Console.ReadKey();

        }
    }
}


