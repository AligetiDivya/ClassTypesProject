namespace ClassTypesProject.Models
{
    // Abstract class: cannot be instantiated directly;
    public abstract class Animal
    {
        // Base class constructor: runs when any derived class object is created.
        public Animal()
        {
            Console.WriteLine("Animal: Base class constructor called.");
        }

        // Abstract method: must be overridden in derived class.
        public abstract void MakeSound();

        // Normal method: can be used by derived classes as is.
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
}
