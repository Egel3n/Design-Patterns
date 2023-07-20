CommandHistory commandHistory = new CommandHistory();
commandHistory.AddCommand(new ConcreteCommand1());
commandHistory.AddCommand(new ConcreteCommand2());
commandHistory.AddCommand(new ConcreteCommand1());
commandHistory.Execute();


public interface ICommand
{
    public void Execute();
}

public class ConcreteCommand1 : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Concrete Command1");
    }
}

public class ConcreteCommand2 : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Concrete Command2");
    }
}

public class CommandHistory : ICommand
{
    private Stack<ICommand> _commands = new Stack<ICommand>();
    public void AddCommand(ICommand command)
    {
        _commands.Push(command);
    }


    public void Execute()
    {
        while (_commands.Count > 0)
        {
            _commands.Pop().Execute();
        }
    }
}
