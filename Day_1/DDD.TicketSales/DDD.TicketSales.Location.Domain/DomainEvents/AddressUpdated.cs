using DDD.TicketSales.Domain.Core;
using DDD.TicketSales.Location.Domain.ValueObjects;

namespace DDD.TicketSales.Location.Domain.DomainEvents;

public class AddressUpdated : ValueObject
{
    public Address Address{ get; }

    public AddressUpdated(Address address)
    {
        Address = address;
    }

    protected override IEnumerable<object> GetValues()
    {
        throw new NotImplementedException();
    }
}