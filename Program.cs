using ObserverDesignPattern;

Console.WriteLine("Observer Design Pattern");
Console.WriteLine("Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.");
Console.WriteLine();

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);
Console.WriteLine();

subject.SomeBusinessLogic();
Console.WriteLine();
subject.SomeBusinessLogic();
Console.WriteLine();

subject.Detach(observerB);
Console.WriteLine();

subject.SomeBusinessLogic();
