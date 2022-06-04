namespace Car.Garage.Repository.Entities;

public class Manufacturer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
}
