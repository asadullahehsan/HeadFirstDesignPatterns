using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage) { }

    public override double Cost() => beverage.Cost() + 0.20;

    public override string Description => beverage.Description + ", Mocha";

}
