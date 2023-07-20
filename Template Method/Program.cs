ConcreteClass1 c1 = new ConcreteClass1();
ConcreteClass2 c2 = new ConcreteClass2();

Console.WriteLine("ConcreteClass1");
c1.TemplateMethod();
Console.WriteLine("\nConcreteClass2");
c2.TemplateMethod();




public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        BasicMethod1();
        BasicMethod2();
        ConcreteMethod1();
        ConcreteMethod2();
        Hook1();
        Hook2();
    }

    protected void BasicMethod1()
    {
        Console.WriteLine("Basic Method 1");
    }
    protected void BasicMethod2()
    {
        Console.WriteLine("Basic Method 2");
    }

    protected abstract void ConcreteMethod1();
    protected abstract void ConcreteMethod2();

    protected virtual void Hook1()
    {
        Console.WriteLine("non-overriden Hook1");
    }
    protected virtual void Hook2()
    {
        Console.WriteLine("non-overriden Hook2");
    }
}

public class ConcreteClass1 : AbstractClass
{
    protected override void ConcreteMethod1()
    {
        Console.WriteLine("Concrete Class 1 : Concrete Method 1");
    }

    protected override void ConcreteMethod2()
    {
        Console.WriteLine("Concrete Class 1 : Concrete Method 2");
    }
}

public class ConcreteClass2 : AbstractClass
{
    protected override void ConcreteMethod1()
    {
        Console.WriteLine("Concrete Class 2 : Concrete Method 1");
    }

    protected override void ConcreteMethod2()
    {
        Console.WriteLine("Concrete Class 2 : Concrete Method 2");
    }

    protected override void Hook1()
    { 
        Console.WriteLine("Overriden Hook1");
    }
    protected override void Hook2()
    {   
        Console.WriteLine("Overriden Hook2");
    }
}