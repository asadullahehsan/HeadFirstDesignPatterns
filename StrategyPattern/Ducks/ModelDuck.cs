using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern.Ducks;

class ModelDuck : Duck
{
    public ModelDuck()
    {
        SetFlyBehavior(new FlyNoWay());
        SetQuackBehavior(new Quack());
    }
    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}
