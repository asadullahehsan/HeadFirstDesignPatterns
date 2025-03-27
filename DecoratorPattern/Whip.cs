namespace DecoratorPattern;

public class Whip : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }

    public override string GetDescription()
    {
        return _beverage.Description + ", Whip";
    }
}
