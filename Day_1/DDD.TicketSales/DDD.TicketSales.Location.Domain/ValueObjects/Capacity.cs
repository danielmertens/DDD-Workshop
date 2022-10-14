using DDD.TicketSales.Domain.Core;

namespace DDD.TicketSales.Location.Domain.ValueObjects
{
    public class Capacity : ValueObject
    {
        public int AllowedCapacity { get; set; }

        public Capacity(int allowedCapacity)
        {
            AllowedCapacity = allowedCapacity;
        }

        protected override IEnumerable<object> GetValues()
        {
            yield return AllowedCapacity;
        }
    }
}