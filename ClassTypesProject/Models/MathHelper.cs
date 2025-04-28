namespace ClassTypesProject.Models
{
    // Static class: cannot be instantiated, only contains static members.
    public static class MathHelper
    {
        // Static constructor: runs once when the class is first used.
        static MathHelper()
        {
            Console.WriteLine("MathHelper: Static constructor called (runs once).");
        }

        // Static method: can be called without creating an object.
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
