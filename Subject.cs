namespace ObserverDesignPattern
{
    public class Subject : ISubject
    {
        public int State { get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Subject: Attached {observer.GetType().Name}");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Subject: Detached {observer.GetType().Name}.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public int GetState() => State;

        public void SomeBusinessLogic()
        {
            State = new Random().Next(0, 10);
            Console.WriteLine($"Subject: The state has changed to: {State}");

            Notify();
        }
    }
}
