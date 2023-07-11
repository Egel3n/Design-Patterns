Subject subject = new Subject();
subject.Attach(new ConcreteObserver());
subject.Attach(new ConcreteObserver2());
subject.Notify();

public interface IObserver
{
    public void Update();
}

public interface ISubject
{
    public void Attach(IObserver observer);
    public void Detach(IObserver observer);
    public void Notify();
}

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
       _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
       _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
    }
   }

public class ConcreteObserver : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserver Updated");
    }
}
public class ConcreteObserver2 : IObserver
{
    public void Update()
    { Console.WriteLine("ConcreteObserver2 Updated"); }
}
