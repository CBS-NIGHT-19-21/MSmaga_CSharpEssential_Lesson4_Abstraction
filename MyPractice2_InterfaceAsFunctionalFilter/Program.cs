
namespace MyPractice2_InterfaceAsFunctionalFilter
{
    class Program
    {
        static void Main(string[] args)
        {   // Up-Casting of the object of class Man to Interface IHusband.
            IHusband manHusbuand = new Man();

            // Use methods of implemented Interface IHusband.
            manHusbuand.WatchTV();
            manHusbuand.CutGrass();

            // Up-Casting of the object of class Man to Interface IWorker.
            IWorker manWorker = new Man();

            // Use methods of implemented Interface IWorker.
            manWorker.Work();
            manWorker.CreateReport();

            // Up-Casting of the object of class Man to Interface IFriend.
            IFriend manFriend = new Man();

            // Use methods of implemented Interface IFriend.
            manFriend.DrinkBeer();
            manFriend.Advice();


            // Delay.
            Console.ReadLine();

        }
    }
}

