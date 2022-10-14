using DDD.TicketSales.Domain.Core;
using DDD.TicketSales.Location.Domain.ValueObjects;

namespace DDD.TicketSales.Location.Domain.DomainEvents
{
    public class CapacityUpdated : DomainEvent
    {
        public Capacity Capacity { get; }

        public CapacityUpdated(Capacity capacity)
        {
            Capacity = capacity;
        }

        protected override IEnumerable<object> GetValues()
        {
            yield return Capacity;
        }
    }
}