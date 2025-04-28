namespace ClassTypesProject.Models
{
    // Derived class: inherits from another class (Animal).
    public class Dog : Animal
    {
        // Calls base class constructor using : base() (constructor chaining).
        public Dog() : base()
        {
            Console.WriteLine("Dog: Derived class constructor called.");
        }

        // Implementation of abstract method from Animal.
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }
}
