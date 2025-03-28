﻿using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;

    public CondimentDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override abstract string Description { get; }
}
