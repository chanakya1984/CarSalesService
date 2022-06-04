namespace Car.Garage.Repository.Entities;

using Common.Enums;

public class CarOnBoarding
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CarModelId { get; set; }
    public CarModel CarMake { get; set; } = new();
    public string KmsDriven { get; set; } = string.Empty;
    public DateOnly? LastServiceDate { get; set; }
    public int? LastServiceDoneAtkms { get; set; }
    public ConditionTypes CosmeticCondition { get; set; }
    public string? CosmeticConditionComment { get; set; }
    public ConditionTypes TyreCondition { get; set; }
    public string? TyreConditionComment { get; set; }
    public ConditionTypes MechanicalCondition { get; set; }
    public string? MechanicalConditionComment { get; set; }
}
