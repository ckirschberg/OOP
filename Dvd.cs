using System;

namespace OOP {
    class Dvd : Media {
        private string director;
        private string mainActor;

        public Dvd(string title, string director, string mainActor) : base(title) {
            this.director = director;
            this.mainActor = mainActor;
        }

        public override void Play() {
            Console.WriteLine("Now playing the Dvd called " + title + " with main actor: " + mainActor); ;
        }
    }
}