using System;
using System.Collections.Generic;

namespace DDD.Domain.Core;

public abstract class Entity : ValueObject
{
    public Guid Id { get; private set; }

    public Entity(Guid id)
    {
        Id = id;
    }

    protected override IEnumerable<object> GetValues()
    {
        yield return Id;
    }
}
