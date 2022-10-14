using System.Collections.Generic;
using System.Linq;

namespace DDD.TicketSales.Domain.Core;

public abstract class AggregateRoot<TKey, TState>
    where TKey : Entity
    where TState : State, new()
{
    private readonly List<IDomainEvent> _events;
    public IReadOnlyList<IDomainEvent> Events => _events;

    public TState CurrentState { get; private set; }
    public TKey Id { get; private set; }
    public int Version { get; private set; }

    public AggregateRoot(TKey identity)
    {
        Id = identity;
        CurrentState = new TState();
        _events = new List<IDomainEvent>();
    }

    public AggregateRoot(TKey identity, TState state, int version)
        : this(identity)
    {
        CurrentState = state;
        Version = version;
    }

    public AggregateRoot(TKey identity, IEnumerable<IDomainEvent> events)
        : this(identity)
    {
        CurrentState.Replay(events);
        Version = events.Count();
    }

    protected void RaiseEvent(IDomainEvent domainEvent)
    {
        CurrentState.Mutate(domainEvent);
        _events.Add(domainEvent);
        Version++;
    }

    public void ClearEvents()
    {
        _events.Clear();
    }
}
