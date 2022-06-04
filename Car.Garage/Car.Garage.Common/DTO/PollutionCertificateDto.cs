namespace Car.Garage.Common.DTO;

public record class PollutionCertificateDto(
    CarOnBoardingDto CarDetails,
    string PucTestId,
    DateOnly ValidTillDate
);
