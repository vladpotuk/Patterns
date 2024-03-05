public class Motorcycle : IVehicle
{
    private readonly string _make;
    private readonly string _type;
    private readonly int _engineSize;
    private readonly string _color;

    public Motorcycle(string make, string type, int engineSize, string color)
    {
        _make = make;
        _type = type;
        _engineSize = engineSize;
        _color = color;
    }

    public string Move()
    {
        return $"Motorcycle {_make} {_type} with {_engineSize}cc engine is moving on the road";
    }

    public string GetDetails()
    {
        return $"Motorcycle: {_make} {_type}, Engine Size: {_engineSize}cc, Color: {_color}";
    }
}
