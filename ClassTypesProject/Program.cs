using System; // Import the System namespace for basic C# functionality
using ClassTypesProject.Interfaces;
using ClassTypesProject.Models;

namespace ClassTypesProject
{
    // Program class contains the Main entry point.
    public class Program
    {
        // Main method: execution starts here.
        static void Main(string[] args)
        {
            // 1. Standard class usage.
            StandardClass std1 = new StandardClass(); // Calls default constructor.
            StandardClass std2 = new StandardClass("Alice"); // Calls parameterized constructor.
            StandardClass std3 = new StandardClass(std2); // Calls copy constructor.

            Console.WriteLine();

            // 2. Abstract & Derived class usage.
            Dog dog = new Dog(); // Calls Animal base and Dog constructor (chaining).
            dog.MakeSound(); // Calls overridden method.
            dog.Eat(); // Calls inherited method.

            Console.WriteLine();

            // 3. Sealed class usage.
            SealedClass sealedObj = new SealedClass(); // Sealed, cannot derive.

            Console.WriteLine();

            // 4. Static class usage. Can't create an object, so call static method.
            int sum = MathHelper.Add(2, 3); // Calls static Add.
            Console.WriteLine($"Static class MathHelper.Add(2, 3) = {sum}");

            Console.WriteLine();

            // 5. Partial class usage.
            PartialClass part = new PartialClass(); // Both methods available.
            part.Method1();
            part.Method2();

            Console.WriteLine();

            // 6. Interface usage.
            IVehicle myCar = new Car(); // Polymorphism: interface reference.
            myCar.Drive(); // Calls Car's Drive.

            Console.WriteLine();

            // 7. Constructors and chaining.
            Person p1 = new Person(); // Default, uses chaining.
            Person p2 = new Person("Bob", 28); // Parameterized.
            Person p3 = new Person(p2); // Copy, uses chaining.

            Console.WriteLine();
        }
    }
}
