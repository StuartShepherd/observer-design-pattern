namespace ObserverDesignPattern
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine($"ConcreteObserverA: Notified - the state is {subject.GetState()}.");
        }
    }
}
