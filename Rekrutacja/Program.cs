using Rekrutacja.Data.Entities;
using Rekrutacja.Data.Enums;
using Rekrutacja.Data.Services;

var specsFactory = new SpecificationFactory();
var specification1 = specsFactory.GetSpecificationV1OrV2(SpecificationType.SpecOne);
var specification2 = specsFactory.GetSpecificationV1OrV2(SpecificationType.SpecTwo);

var testObjectWithSpecOne = new TestObject(specification1);
var testObjectWithSpecTwo = new TestObject(specification2);

var tasks = new []
{
    testObjectWithSpecOne.ApplyDefaultValuesAsync(),
    testObjectWithSpecTwo.ApplyDefaultValuesAsync()
};

await Task.WhenAll(tasks);

Console.Write("\nClick anything to continue...");
Console.ReadKey();