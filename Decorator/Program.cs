ConcreteClass concrete = new ConcreteClass { value = 100 };
ConcreteDecorator decorator = new ConcreteDecorator(concrete);
Console.WriteLine(concrete.value);
Console.WriteLine(decorator.value);



abstract class BaseClass
{
    public abstract decimal value { get; set; }
}

class ConcreteClass : BaseClass
{
    public override decimal value { get; set; }
}

abstract class BaseDecorator:BaseClass
{
    private BaseClass _base;
    public BaseDecorator(BaseClass baseClass)
    {
        _base = baseClass;
    }
}

class ConcreteDecorator : BaseDecorator
{
    private BaseClass _base;
    public ConcreteDecorator(BaseClass baseClass) : base(baseClass)
    {
        _base = baseClass;
    }

    public override decimal value
    {
        get { return _base.value * 90 / 100; }
        set { }
    }
}