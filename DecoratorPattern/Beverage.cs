namespace DecoratorPattern;

public abstract class Beverage
{
    public string Description { get; private set; } = "Unknown Beverage";

    public abstract double Cost();
}
