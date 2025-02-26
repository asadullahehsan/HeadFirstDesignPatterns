namespace StrategyPattern.QuackBehaviors;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("Quack");
    }
}
