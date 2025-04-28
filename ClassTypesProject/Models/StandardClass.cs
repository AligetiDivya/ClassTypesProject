// Namespace helps organize your code and avoid name conflicts.
namespace ClassTypesProject
{
    // A standard class is a normal class, can create objects from.
    public class StandardClass
    {
        // Default constructor: runs when you create object with no parameters.
        public StandardClass()
        {
            Console.WriteLine("StandardClass: Default constructor called.");
        }

        // Parameterized constructor: lets you set data when creating object.
        public StandardClass(string name)
        {
            Console.WriteLine($"StandardClass: Parameterized constructor called. Name: {name}");
        }

        // Copy constructor: creates new object as a copy of another object.
        public StandardClass(StandardClass other)
        {
            Console.WriteLine("StandardClass: Copy constructor called.");
        }
    }
}
