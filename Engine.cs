namespace OOP {
    class Engine {
        public string Name { get; set; }
        public double Horsepower { get; set; }
        
        // Constructor
        public Engine(string name, double horsepower){
            this.Name = name;
            this.Horsepower = horsepower;
        }
        // Default constructor - 
        public Engine(double horse) {
            this.Horsepower = horse;
        }

    }
}