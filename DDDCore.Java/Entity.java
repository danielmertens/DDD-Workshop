package com.infosupport.ddd.domain.core;

import java.util.UUID;

public abstract class Entity extends ValueObject {

    private final UUID _id;
    
    public Entity(UUID id) {
        _id = id;
    }
    
    public UUID getId() {
        return _id;
    }
}
