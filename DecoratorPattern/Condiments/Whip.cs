using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage) { }

    public override double Cost() => beverage.Cost() + 0.10;

    public override string Description => beverage.Description + ", Whip";
}
