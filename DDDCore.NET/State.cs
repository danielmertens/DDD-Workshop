using System.Collections.Generic;

namespace DDD.Domain.Core;

public abstract class State
{
    public void Mutate(IDomainEvent evt)
    {
        ((dynamic)this).When((dynamic)evt);
    }

    public void Replay(IEnumerable<IDomainEvent> domainEvents)
    {
        foreach (var evt in domainEvents)
        {
            Mutate(evt);
        }
    }
}
