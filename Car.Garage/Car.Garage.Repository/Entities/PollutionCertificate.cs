namespace Car.Garage.Repository.Entities;

public class PollutionCertificate
{
    public int Id { get; set; }
    public int CarOnBoardingId { get; set; }
    public CarOnBoarding CarDetails { get; set; } = new CarOnBoarding();
    public string PucTestId { get; set; } = string.Empty;
    public DateOnly ValidTillDate { get; set; }
}
