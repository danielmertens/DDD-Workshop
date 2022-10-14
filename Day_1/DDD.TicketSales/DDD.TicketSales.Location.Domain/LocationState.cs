using DDD.TicketSales.Domain.Core;
using DDD.TicketSales.Location.Domain.DomainEvents;
using DDD.TicketSales.Location.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TicketSales.Location.Domain;

public class LocationState : State
{
    public Address Address { get; private set; }
    public Capacity Capacity { get; private set; }

    public void When(AddressUpdated evt)
    {
        Address = evt.Address;
    }

    public void When(CapacityUpdated evt)
    {
        Capacity = evt.Capacity;
    }






}
