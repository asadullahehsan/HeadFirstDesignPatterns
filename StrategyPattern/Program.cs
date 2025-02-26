using StrategyPattern.Ducks;
using StrategyPattern.FlyBehaviors;

Console.WriteLine("SimUDuck Simulator\n");

Duck mallard = new MallardDuck();

mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();

model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();

Duck rubber = new RubberDuck();
rubber.PerformQuack();
rubber.PerformFly();
