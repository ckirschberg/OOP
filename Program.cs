using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //type objName = new class();
            // Default constructor
            Engine engine1 = new Engine(230);
            Engine engine2 = new Engine("V8", 300);


            Car car1 = new Car("Tesla", "Model 3", "Black", 4, engine1);
            Car car2 = new Car("Ford", "Focus", "White", 5, engine2);

            // This is not allowed, because I deleted the "set-method".
            // car1.Engine = engine2;
            

            Console.WriteLine(car1);
            // Console.WriteLine(car1.model);
            // Console.WriteLine(car1.color);
            // Console.WriteLine(car1.numberOfDoors);

            Console.WriteLine("Hello World!");
        }
    }
}
