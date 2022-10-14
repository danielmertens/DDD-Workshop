using DDD.TicketSales.Domain.Core;

namespace DDD.TicketSales.Location.Domain.ValueObjects;

public class Street : ValueObject
{
    public string Name { get; }

    public Street(string name)
    {
        Name = name;
    }

    protected override IEnumerable<object> GetValues()
    {
        yield return Name;
    }
}
