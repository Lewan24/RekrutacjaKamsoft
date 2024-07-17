using Rekrutacja.Data.Interfaces;

namespace Rekrutacja.Data.Entities;

internal sealed class TestObject(ISpecification specification)
{
    public async Task ApplyDefaultValuesAsync() 
        => await specification.ApplyAsync();
}