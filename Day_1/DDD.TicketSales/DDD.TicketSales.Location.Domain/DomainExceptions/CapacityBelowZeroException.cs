using DDD.TicketSales.Domain.Core;
using DDD.TicketSales.Location.Domain.ValueObjects;
using System.Runtime.Serialization;

namespace DDD.TicketSales.Location.Domain.DomainExceptions
{
    [Serializable]
    internal class CapacityBelowZeroException : DomainRuleViolation
    {
        private Capacity capacity;

        public CapacityBelowZeroException()
        {
        }

        public CapacityBelowZeroException(Capacity capacity)
        {
            this.capacity = capacity;
        }

    }
}