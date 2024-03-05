using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicleFactory carFactory = new CarFactory();
        IVehicleFactory motorcycleFactory = new MotorcycleFactory();

        IVehicle car = carFactory.CreateVehicle();
        IVehicle motorcycle = motorcycleFactory.CreateVehicle();

        Console.WriteLine(car.Move());
        Console.WriteLine(car.GetDetails());

        Console.WriteLine(motorcycle.Move());
        Console.WriteLine(motorcycle.GetDetails());
    }
}
