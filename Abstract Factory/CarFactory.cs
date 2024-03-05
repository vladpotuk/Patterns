public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        
        return new Car("Toyota", "Camry", 2023, "Black");
    }
}
