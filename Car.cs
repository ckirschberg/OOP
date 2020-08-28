namespace OOP 
{
    class Car
    {
        // Encapsulation - encapsulate, what other programmers should not "deal with".
        //private means only access from within class itself.
        // C# attributes/fields
        private string brand, model, color;
        private int numberOfDoors;

        // C# property
        public Engine Engine { get; }

        // Constructor

        // You can have multiple constructors to give other programmers multiple options of 
        // instanciating the class (creating an object)
        public Car(string brand, string model, string color, Engine engine) {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.Engine = engine;
        }
        public Car(string brand, string model, string color, int numberOfDoors, Engine engine) : this(brand, model, color, engine) {
            this.numberOfDoors = numberOfDoors;
        }

        // For setting the brand value (or to update it in an existing object)
        public void setBrand(string brand) {
            this.brand = brand;
        }
        
        // Retrieve the value of the brand
        public string getBrand() {
            return brand;
        }

        // Easy way to print out an entire object.
        // Console.WriteLine(*object name*) - auto. calls the ToString method.
        public override string ToString() {
            return this.brand + " " + this.model + " in " 
                + this.color + " with " + this.numberOfDoors + " doors!";
        }
    }

}