namespace ObserverDesignPattern
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine($"ConcreteObserverB: Notified - the state is {subject.GetState()}.");
        }
    }
}
