namespace Car.Garage.Common.DTO;

using Enums;

public record class CarModelDto(
    CarManufacturerDto Manufacturer,
    string Name,
    CarFuelType FuelType,
    string EngineCapacity);
