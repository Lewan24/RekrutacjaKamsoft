using Rekrutacja.Data.Interfaces;

namespace Rekrutacja.Data.Entities.Specifications;

internal sealed class SpecificationV2 : ISpecification
{
    public async Task ApplyAsync()
    {
        Console.WriteLine("Applying specification V2...");

        await Task.Delay(300);
        
        Console.WriteLine("Successfully applied specification V2 to the object.");
    }
}