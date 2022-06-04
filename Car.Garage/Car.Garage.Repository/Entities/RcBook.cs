namespace Car.Garage.Repository.Entities;

public class RcBook
{
    public int Id { get; set; }
    public int CarOnBoardingId { get; set; }
    public CarOnBoarding CarDetails { get; set; } = new CarOnBoarding();
}
