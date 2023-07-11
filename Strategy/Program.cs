Context context = new Context();
context.setStrategy(new Concrete2());
context.Do();


public interface Strategy
{
    public void DoSomething();
}

public class Concrete1 : Strategy
{
    public void DoSomething()
    {
        Console.WriteLine("Concrete1 did something");
    }
}

public class Concrete2 : Strategy
{
    public void DoSomething()
    {
        Console.WriteLine("Concrete2 did something");
    }
}

public class Context
{
    private Strategy _strategy;

    public void setStrategy(Strategy strategy)
    {
        this._strategy = strategy;
    }

    public void Do()
    {
        _strategy.DoSomething();
    }
}