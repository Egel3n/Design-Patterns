

SubClassProxy proxy = new SubClassProxy();

Console.WriteLine(proxy.Calculate(3));
Console.WriteLine(proxy.Calculate(3));
Console.WriteLine(proxy.Calculate(2));




abstract class SuperClass
{
    public abstract int Calculate(int a);
}


class SubClass : SuperClass
{
    public override int Calculate(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Thread.Sleep(1000);
        }
        return a;
    }
}

class SubClassProxy : SuperClass
{
    SubClass _subclass;
    int _cashedValue;
    int _prevValue;

    public override int Calculate(int a)
    {
        if(_subclass == null || _prevValue != a)
        {
            _subclass = new SubClass();
            _subclass.Calculate(a);
            _prevValue = a;
            _cashedValue = a;
        }
        return _cashedValue;
    }
}