using StrategyPattern.FlyBehaviors;
using StrategyPattern.QuackBehaviors;
namespace StrategyPattern.Ducks;

public abstract class Duck
{
    IFlyBehavior _flyBehavior;
    IQuackBehavior _quackBehavior;

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        _flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        _quackBehavior = qb;
    }

    public abstract void Display();
    
    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public void Swim()
    {
        Console.WriteLine("Swim...");
    }
}
