namespace ClassTypesProject.Models
{
    // Partial class: definition can be split into multiple files/parts.
    public partial class PartialClass
    {
        // First part of PartialClass.
        public void Method1()
        {
            Console.WriteLine("PartialClass: Method1.");
        }
    }

    // Second part of PartialClass.
    public partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("PartialClass: Method2.");
        }
    }
}
