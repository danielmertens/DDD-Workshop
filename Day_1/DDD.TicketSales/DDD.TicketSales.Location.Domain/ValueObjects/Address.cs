using DDD.TicketSales.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TicketSales.Location.Domain.ValueObjects;

public class Address : ValueObject
{
    public Street Street { get; }
    public BusNumber BusNumber { get; set; }

    public Address(Street street, BusNumber busNumber)
    {
        Street = street;
        BusNumber = busNumber;
    }

    protected override IEnumerable<object> GetValues()
    {
        yield return Street;
    }
}
