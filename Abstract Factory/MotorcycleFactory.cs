public class MotorcycleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        
        return new Motorcycle("Honda", "CBR", 1000, "Red");
    }
}
