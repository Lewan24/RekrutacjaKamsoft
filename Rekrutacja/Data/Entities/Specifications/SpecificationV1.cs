using Rekrutacja.Data.Interfaces;

namespace Rekrutacja.Data.Entities.Specifications;

internal sealed class SpecificationV1 : ISpecification
{
    public async Task ApplyAsync()
    {
        Console.WriteLine("Applying specification V1...");

        await Task.Delay(500);
        
        Console.WriteLine("Successfully applied specification V1 to the object.");
    }
}