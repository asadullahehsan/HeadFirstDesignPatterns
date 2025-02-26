using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern.Ducks;

class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        SetFlyBehavior(new FlyWithWings());
        SetQuackBehavior(new Quack());
    }

    public override void Display()
    {
        Console.WriteLine("This is Redhead Duck");
    }
}
