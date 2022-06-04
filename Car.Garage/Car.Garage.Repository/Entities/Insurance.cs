namespace Car.Garage.Repository.Entities;

using System.ComponentModel.DataAnnotations.Schema;

public class Insurance
{
    public int Id { get; set; }
    [ForeignKey("CarOnBoardingId")]
    public int CarOnBoardingId { get; set; }
    public CarOnBoarding CarDetails { get; set; } = new CarOnBoarding();
    public string InsuranceProviderName { get; set; } = string.Empty;
    public string InsuranceId { get; set; } = string.Empty;
    public bool IsComprehensive { get; set; }
    public DateOnly InsuranceValidTill { get; set; }
    public bool IsAnyClaimInDuration { get; set; }
    public int NoOfClaimsIfAny { get; set; }
    public decimal IdvValue { get; set; }
}
