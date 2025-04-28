namespace ClassTypesProject.Models
{
    // Car implements IVehicle interface.
    public class Car : Interfaces.IVehicle
    {
        // Default constructor.
        public Car()
        {
            Console.WriteLine("Car: Default constructor called.");
        }

        // Implement Drive() method from IVehicle.
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
}
