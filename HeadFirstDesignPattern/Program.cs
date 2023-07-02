// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPattern.DecoratorPattern;
using HeadFirstDesignPattern.Entity;
using HeadFirstDesignPattern.Interfaces.Implementations;
using HeadFirstDesignPattern.ObserverPattern;

#region Strategy Pattern
//Duck mallard=new MallardDuck();
//mallard.Display();
//mallard.PerfomFly();
//mallard.PerformQuack();

//Duck modelDuck = new ModelDuck();
//modelDuck.PerfomFly();
//modelDuck.SetDuckBehaviour(new FlyWithWings());
//modelDuck.PerfomFly();
//modelDuck.SetDuckBehaviour(new FlyRocketPowered());
//modelDuck.PerfomFly();

//Character character = new KnightCharacter();
////character.SetWeapon(new SwordBehaviour());
//character.fight();
//character.UseWeapon();
#endregion

#region Observer Pattern
//// Publisher Instantiated
//Publisher publisher = new Publisher();

//// Observer Subscribes to Publisher
//LogObserver logObserver=new LogObserver(publisher);
//EventLogObserver eventLogObs = new EventLogObserver(publisher);

//// Manually send data to publisher
//publisher.SetNotificationData("CLICK", "User Clicked the mouse");
//publisher.SetNotificationData("LOGIN","User Logged In");

//// Terminate one of the two Subscription
//eventLogObs.Unregister();

//// Test with one subscriber
//publisher.SetNotificationData("LOGOUT", "User Logged Out");
//publisher.SetNotificationData("LOGOUT-Retry", "User Logged Out again");
#endregion

#region Decorator Pattern
Beverage beverage = new HouseBlend();
Console.WriteLine($"Ordered {beverage.Cost()} description= {beverage.GetDescription()}");

//Beverage beverage1 = new Decaf();
//beverage1 = new MochaCondiment(beverage1);
//beverage1 = new MochaCondiment(new MochaCondiment(beverage1));
Beverage beverage1 = new WhipCondiment(new SoyCondiment(new MochaCondiment(new MochaCondiment(new Decaf()))));
Console.WriteLine($"Ordered {beverage1.Cost()} Description= {beverage1.GetDescription()}");
#endregion