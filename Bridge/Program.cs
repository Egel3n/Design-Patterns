Manager manager = new Manager();
manager.Sender = new ConcreteSms(); //BRIDGE PATTERN
manager.Update("Important Message");


abstract class SuperClass
{
    public void Save()
    {
        Console.WriteLine("Saved to Database");
    }

    public abstract void SendMessage(string message);
}

class ConcreteSms : SuperClass
{
    public override void SendMessage(string message)
    {
        Console.Write(message+" --Sent via SMS");
    }
}

class ConcreteMail : SuperClass
{
    public override void SendMessage(string message)
    {
        Console.WriteLine(message+" --Sent via Mail");
    }
}

class Manager
{
    public SuperClass Sender { get; set; }

    public void Update(string message)
    {
        Sender.Save();
        Sender.SendMessage(message);
    }
}