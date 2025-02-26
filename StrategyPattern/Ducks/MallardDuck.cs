using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern.Ducks;

class MallardDuck : Duck
{
    public MallardDuck()
    {
        SetFlyBehavior(new FlyWithWings());
        SetQuackBehavior(new Quack());
    }

    public override void Display()
    {
        Console.WriteLine("This is Mallard Duck");
    }
}
