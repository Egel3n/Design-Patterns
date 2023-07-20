BusinessLayer business1 = new BusinessLayer(new ConcreteLayer1());
business1.Run();
BusinessLayer business2 = new BusinessLayer(new ConcreteLayer2());
business2.Run();



public interface IDataLayer
{
    public void Run();   
}

public class ConcreteLayer1 : IDataLayer
{
    public void Run()
    {
        Console.WriteLine("ConcreteLayer1 Running");
    }
}

public class ConcreteLayer2 : IDataLayer
{
    public void Run()
    {
        Console.WriteLine("ConcreteLayer2 Running");
    }
}

public class BusinessLayer
{
    private IDataLayer _dataLayer;

    public BusinessLayer(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }
    public void Run()
    {
        _dataLayer.Run();
    }
}