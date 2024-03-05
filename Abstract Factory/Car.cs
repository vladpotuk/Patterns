public class Car : IVehicle
{
    private readonly string _brand;
    private readonly string _model;
    private readonly int _year;
    private readonly string _color;

    public Car(string brand, string model, int year, string color)
    {
        _brand = brand;
        _model = model;
        _year = year;
        _color = color;
    }

    public string Move()
    {
        return $"{_year} {_brand} {_model} is moving on the road";
    }

    public string GetDetails()
    {
        return $"Car: {_year} {_brand} {_model}, Color: {_color}";
    }
}
