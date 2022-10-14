
using DDD.TicketSales.Location.Domain;
using DDD.TicketSales.Location.Domain.ValueObjects;

var location = new LocationAggregate(new LocationReference(Guid.NewGuid()));

location.UpdateCapacity(new Capacity(50));

Console.WriteLine("OK");
