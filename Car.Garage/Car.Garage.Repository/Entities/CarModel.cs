namespace Car.Garage.Repository.Entities;
using Car.Garage.Common.Enums;

public class CarModel
{
    public int Id { get; set; }
    public int ManufactureId { get; set; }
    public Manufacturer Manufacturer { get; set; } = new Manufacturer();
    public string Name { get; set; } = string.Empty;
    public CarFuelType FuelType { get; set; }
    public string EngineCapacity { get; set; } = string.Empty;

}
