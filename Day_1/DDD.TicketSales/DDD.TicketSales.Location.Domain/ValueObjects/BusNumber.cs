using DDD.TicketSales.Domain.Core;

namespace DDD.TicketSales.Location.Domain.ValueObjects
{
    public class BusNumber : ValueObject
    {
        public int number { get; }

        public BusNumber(int number)
        {
            this.number = number;
        }

        protected override IEnumerable<object> GetValues()
        {
            yield return number;
        }
    }
}