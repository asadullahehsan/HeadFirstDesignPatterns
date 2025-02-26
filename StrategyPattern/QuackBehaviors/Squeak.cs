namespace StrategyPattern.QuackBehaviors;

class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
