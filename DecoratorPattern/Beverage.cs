namespace DecoratorPattern;

public abstract class Beverage
{

    private string description = "Unknown Beverage";

    public string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}
