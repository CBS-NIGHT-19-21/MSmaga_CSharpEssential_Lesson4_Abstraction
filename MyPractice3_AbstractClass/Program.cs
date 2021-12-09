namespace MyPractice3_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Bird bird = new Bird();
            Fish fish = new Fish();

            dog.Voice();
            bird.Voice();
            fish.Voice();


            dog.Move();
            bird.Move();
            fish.Move();
        }
    }
}

