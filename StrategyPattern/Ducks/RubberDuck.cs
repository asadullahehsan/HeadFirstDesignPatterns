using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern.Ducks;

class RubberDuck: Duck
{
    public RubberDuck()
    {
        SetFlyBehavior(new FlyNoWay());
        SetQuackBehavior(new Squeak());
    }

    public override void Display()
    {
        Console.WriteLine("This is Rubber Duck");
    }
}
