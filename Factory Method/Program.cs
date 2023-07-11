
var factory1 = new Factory1();
factory1.produce();
var factory2 = new Factory2();
factory2.produce();

public interface Product{
    void dosomething();
}

class ConcreteProduct1 : Product
{
    public void dosomething()
    {
        Console.WriteLine("Product 1 did something");
    }

}

class ConcreteProduct2 : Product
{
    public void dosomething()
    {
        Console.WriteLine("Product 2 did something");
    }
}

public abstract class MainFactory
{
    public abstract Product FactoryMethod();
    public void produce()
    {
        var product = FactoryMethod();
        product.dosomething();
    }
}

public class Factory1 : MainFactory
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct1();
    }

}

public class Factory2 : MainFactory
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct2();
    }

}