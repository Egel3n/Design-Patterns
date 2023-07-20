Person p1 = new Person("Ege", 21);
CareTaker careTaker = new CareTaker();

careTaker.Backup(p1);
p1.SetName("Gelen");
careTaker.Backup(p1);
p1.SetAge(20);
Console.WriteLine("Starting: "+ p1.GetName() + " "+ p1.GetAge());

Memento firstUndo = careTaker.Restore(p1);
p1.SetName(firstUndo.GetName());
p1.SetAge((int)firstUndo.GetAge());
Console.WriteLine("Undo: " + p1.GetName() + " " + p1.GetAge());

Memento secondUndo = careTaker.Restore(p1);
p1.SetName(secondUndo.GetName());
p1.SetAge((int)secondUndo.GetAge());
Console.WriteLine("Undo: " + p1.GetName() + " " + p1.GetAge());

Memento firstRedo = careTaker.Redo(p1);
p1.SetName(firstRedo.GetName());
p1.SetAge((int)firstRedo.GetAge());
Console.WriteLine("Redo: " + p1.GetName() + " " + p1.GetAge());

Memento thirdUndo = careTaker.Restore(p1);
p1.SetName(thirdUndo.GetName());
p1.SetAge((int)thirdUndo.GetAge());
Console.WriteLine("Undo: " + p1.GetName() + " " + p1.GetAge());



public class Person
{
    private string _name;
    private int _age;

    public Person(string Name, int age)
    {
        _name = Name;
        _age = age;
    }

    public string GetName() { return _name; }
    public int GetAge() { return _age; }
    public void SetAge(int age) { this._age = age; }
    public void SetName(string name) { this._name = name; }
}
public class Memento
{
    private int _age;
    private string _name;
    public Memento(Person person)
    {
        this._age = person.GetAge();
        this._name = person.GetName();
    }

    public int GetAge() { return _age;}
    public string GetName() { return _name;}
  
}

public class CareTaker
{
    Stack<Memento> _stackUndo = new Stack<Memento>();
    Stack<Memento> _stackRedo = new Stack<Memento>();

    public void Backup(Person person)
    {
        _stackUndo.Push(new  Memento(person));
    }
    public Memento Restore(Person person)
    {
        Memento restoredData = _stackUndo.Pop();
        _stackRedo.Push(new Memento(person));
        return restoredData;
    }
    public Memento Redo(Person person)
    {
        Memento redoedData = _stackRedo.Pop();
        _stackUndo.Push(new Memento(person));
        return redoedData;
    }
}