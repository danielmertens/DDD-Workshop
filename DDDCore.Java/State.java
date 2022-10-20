package com.infosupport.ddd.domain.core;

import java.util.Iterator;

public abstract class State {

    public abstract void Mutate(IDomainEvent evt);
    
    public void Replay(Iterable<IDomainEvent> domainEvents) {
        for (Iterator<IDomainEvent> iterator = domainEvents.iterator(); iterator.hasNext();) {
            Mutate(iterator.next());
        }
    }
}
