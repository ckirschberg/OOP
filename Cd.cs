namespace OOP {
    class Cd : Media {

        private string artist;

        public Cd(string title, string artist) : base(title) {
            this.artist = artist;
        }
    }
}