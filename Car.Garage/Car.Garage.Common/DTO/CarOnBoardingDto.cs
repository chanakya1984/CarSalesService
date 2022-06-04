namespace Car.Garage.Common.DTO;

using Enums;

public record class CarOnBoardingDto(
    CarModelDto CarMake,
    string KmsDriven,
    DateOnly LastServiceDate,
    DateOnly LastServiceDoneAtkms,
    ConditionTypes CosmeticCondition,
    string? CosmeticConditionComment,
    ConditionTypes TyreCondition,
    string? TyreConditionComment,
    ConditionTypes MechanicalCondition,
    string? MechanicalConditionComment,
    RcBookDto RcBookDetail,
    InsuranceDto InsuranceDetail,
    PollutionCertificateDto PollutionCertificateDetail
);
