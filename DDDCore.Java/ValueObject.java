package com.infosupport.ddd.domain.core;

import java.util.Arrays;

public abstract class ValueObject {
    
    protected abstract Object[] getValues();

    @Override
    public boolean equals(Object obj) {
        return ((obj != null) 
            && ((this.getClass() == obj.getClass()) 
            && ValueObject.AreEqual(this, ((ValueObject)(obj)))));
    }

    @Override
    public int hashCode() {
        int hash = 2;
        for (Object value : getValues()) {
            hash^=value.hashCode();
        }
        return hash;
    }
    
    private static boolean AreEqual(ValueObject left, ValueObject right) {
        if (left == null) {
            return right == null;
        }
        var leftValues = left.getValues();
        var rightValues = right.getValues();
        
        return Arrays.deepEquals(leftValues, rightValues);
    }
}