namespace TestingFundamentalsApi.Entities;

internal class Car(Guid id, string name)
{
    public Guid Id { get; init; } = id;
    public string Name { get; set; } = name;
}