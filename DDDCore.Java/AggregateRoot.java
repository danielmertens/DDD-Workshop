package com.infosupport.ddd.domain.core;

import java.util.ArrayList;

public class AggregateRoot<TKey extends Entity, TState extends State> {

    private final ArrayList<IDomainEvent> _events;
    private TState _currentState;
    private TKey _id;
    private int _version;
    
    public AggregateRoot(TKey id) {
        _id = id;
        _events = new ArrayList<>();
    }
    
    
    public Iterable<IDomainEvent> getEvents() {
        return _events;
    }
}
