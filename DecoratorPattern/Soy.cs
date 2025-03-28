namespace DecoratorPattern;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage) { }

    public override double Cost() => beverage.Cost() + 0.15;

    public override string Description => beverage.Description + ", Soy";
}
