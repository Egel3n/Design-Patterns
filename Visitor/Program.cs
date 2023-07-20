ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
ConcreteCompound1 comp1 = new ConcreteCompound1();
ConcreteCompound2 comp2 = new ConcreteCompound2();

Client client = new Client();
client.compounds.Add(comp1);
client.compounds.Add(comp2);
client.visitor = visitor1;

client.ClientCode();

client.visitor = visitor2;

client.ClientCode();



public interface IVisitor
{
    public void Visit(ConcreteCompound1 compound);
    public void Visit(ConcreteCompound2 compound);
}

public abstract class Compound
{
    public abstract void accept(IVisitor visitor);
}

public class ConcreteCompound1 : Compound
{
    public int value = 100;
    public override void accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    public void PrintValue()
    {
        Console.WriteLine(value);
    }
}

public class ConcreteCompound2 : Compound
{
    public int value = 200;
    public override void accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ConcreteVisitor1 : IVisitor
{
    public void Visit(ConcreteCompound1 compound)
    {
        compound.value *= 2;
        Console.WriteLine(compound.value + "-Doubled by Concrete1");
    }

    public void Visit(ConcreteCompound2 compound)
    {
        compound.value *= 2;
        Console.WriteLine(compound.value + "-Doubled by Concrete1");
    }
}

public class ConcreteVisitor2 : IVisitor
{
    public void Visit(ConcreteCompound1 compound)
    {
        compound.value *= 4;
        Console.WriteLine(compound.value + "-Quadrupled by Concrete2");
    }

    public void Visit(ConcreteCompound2 compound)
    {
        compound.value *= 4;
        Console.WriteLine(compound.value + "-Quadrupled by Concrete2");
    }
}

public class Client
{
    public List<Compound> compounds = new List<Compound>();
    public IVisitor visitor;

    public void ClientCode()
    {
        foreach(Compound comp in compounds)
        {
            comp.accept(visitor);
        }
    }
}