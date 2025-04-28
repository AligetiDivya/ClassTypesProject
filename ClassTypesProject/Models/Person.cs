namespace ClassTypesProject.Models
{
    // Person class: demonstrates all constructor types and chaining.
    public class Person
    {
        // Public properties.
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor: chains to parameterized constructor.
        public Person() : this("Unknown", 0)
        {
            Console.WriteLine("Person: Default constructor called.");
        }

        // Parameterized constructor: lets you set data when creating object.
        public Person(string name, int age)
        {
            Name = name; // Set Name property.
            Age = age;   // Set Age property.
            Console.WriteLine($"Person: Parameterized constructor called. Name: {Name}, Age: {Age}");
        }

        // Copy constructor: makes a new object from another.
        public Person(Person other) : this(other.Name, other.Age)
        {
            Console.WriteLine("Person: Copy constructor called.");
        }

        // Static constructor: runs once before any object is created or any static member is accessed.
        static Person()
        {
            Console.WriteLine("Person: Static constructor called.");
        }

        // Private constructor: cannot be called from outside; used for special patterns (e.g., Singleton).
        private Person(string secret)
        {
            Console.WriteLine("Person: Private constructor called. Only accessible inside the class.");
        }
    }
}
