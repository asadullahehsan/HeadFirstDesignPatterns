using DecoratorPattern;

Console.WriteLine("Decorator Pattern\n\n");

Beverage beverage = new Espresso();
beverage = new Mocha(beverage);
Console.WriteLine(beverage.Description + " - $" + beverage.Cost());

Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
//beverage2 = new Mocha(beverage2);
//beverage2 = new Whip(beverage2);
Console.WriteLine(beverage2.Description + " - $" + beverage2.Cost());

