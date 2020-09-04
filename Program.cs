using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cd cd1 = new Cd("Backstreet Boys is back!", "Backstreet Boys");
            // cd1.Play();

            Dvd dvd1 = new Dvd("What women want", "Bob dillon", "Mel Gibson");
            // dvd1.Play();


            List<Media> medias = new List<Media>();
            // Polymorphism - A Cd object or Dvd, has many "shapes" or types. A Cd and a media or Dvd and media
            // Therefore you can create a list of media and put Cds and Dvds in the list.
            medias.Add(cd1);
            medias.Add(dvd1);

                    //type
            foreach(Media media in medias) {
                media.Play();
            }

            


            // //type objName = new class();
            // // Default constructor
            // Engine engine1 = new Engine(230);
            // Engine engine2 = new Engine("V8", 300);

            // Car car1 = new Car("Tesla", "Model 3", "Black", 4, engine1);
            // Car car2 = new Car("Ford", "Focus", "White", 5, engine2);

            // // This is not allowed, because I deleted the "set-method".
            // // car1.Engine = engine2;


            // Console.WriteLine(car1);
            // // Console.WriteLine(car1.model);
            // // Console.WriteLine(car1.color);
            // // Console.WriteLine(car1.numberOfDoors);

            // Console.WriteLine("Hello World!");
        }
    }
}
