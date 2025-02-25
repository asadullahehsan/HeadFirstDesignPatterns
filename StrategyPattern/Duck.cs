using System;

namespace StrategyPattern;

class Duck
{
    public void Quack()
    {
        Console.WriteLine("Quack...");
    }

    public void Swim()
    {
        Console.WriteLine("Swim...");
    }

    public void Display()
    {
        Console.WriteLine("This is Duck");
    }

    public void Fly()
    {
        Console.WriteLine("Fly...");
    }
}
