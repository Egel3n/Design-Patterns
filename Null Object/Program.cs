BusinessLayer business = new BusinessLayer(StubConcreteLayer.GetInstance());
business.Run();



// Dependency Injection Codes
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

//NULL OBJECT STARTS FROM HERE
public class StubConcreteLayer : IDataLayer
{
    private static StubConcreteLayer _singleton;
    private static object _lock = new object();
    private StubConcreteLayer() {  }

    public static StubConcreteLayer GetInstance()
    {
        lock (_lock)
        {
            if(_singleton == null)
            {
                _singleton = new StubConcreteLayer();
            }
            return _singleton;
        }
    }


    public void Run()
    {
        
    }
}
