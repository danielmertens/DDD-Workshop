using DDD.TicketSales.Domain.Core;
using DDD.TicketSales.Location.Domain.DomainEvents;
using DDD.TicketSales.Location.Domain.DomainExceptions;
using DDD.TicketSales.Location.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TicketSales.Location.Domain;

public class LocationAggregate : AggregateRoot<LocationReference, LocationState>
{
    public LocationAggregate(LocationReference identity) 
        : base(identity)
    {
    }

    public LocationAggregate(
        LocationReference identity, 
        IEnumerable<IDomainEvent> events) 
        : base(identity, events)
    {
    }

    public LocationAggregate(
        LocationReference identity, 
        LocationState state, 
        int version) 
        : base(identity, state, version)
    {
    }

    public void UpdateCapacity(Capacity capacity)
    {
        if (capacity.AllowedCapacity < 0)
        {
            throw new CapacityBelowZeroException(capacity);
        }

        RaiseEvent(new CapacityUpdated(capacity));
    }





}
