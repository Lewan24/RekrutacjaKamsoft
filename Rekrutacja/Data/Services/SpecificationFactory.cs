using Rekrutacja.Data.Entities.Specifications;
using Rekrutacja.Data.Enums;
using Rekrutacja.Data.Interfaces;

namespace Rekrutacja.Data.Services;

internal sealed class SpecificationFactory
{
    public ISpecification GetSpecificationV1OrV2(SpecificationType specType) => specType switch
    {
        SpecificationType.SpecOne => new SpecificationV1(),
        SpecificationType.SpecTwo => new SpecificationV2(),
        // Other future specifications should be added here, or create extension method to handle new versions of specifications
        _ => throw new ArgumentException("Can't match specification type.", nameof(specType))
    };
}

// Example of possible extension method to factory (without need of editing existing one)
internal static class SpecificationFactoryExtension
{
    // Im using here the same enum as the specification type, but could be new one if needed, depends on needs
    public static ISpecification GetSpecificationV3OrV4(this SpecificationFactory factory, SpecificationType specType) => specType switch
    {
        // SpecificationType.SpecThree => new SpecificationV3(),
        // SpecificationType.SpecFour => new SpecificationV4(),
        _ => throw new ArgumentException("Can't match specification type.", nameof(specType))
    };
}