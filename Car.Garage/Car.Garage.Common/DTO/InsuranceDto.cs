namespace Car.Garage.Common.DTO;

public record class InsuranceDto(
    CarOnBoardingDto CarDetails,
    string InsuranceProviderName,
    string InsuranceId,
    string IsComprehensive,
    DateOnly InsuranceValidTill,
    bool IsAnyClaimInDuration,
    int NoOfClaimsIfAny,
    decimal IdvValue
    );
