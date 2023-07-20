Context context = new Context();
context.Operation1();
context.Operation2();
context.StateChange(new ConcreteState2(context));
context.Operation1();
context.Operation2();



public class Context
{
    private State _state;

    public Context()
    {
        this.StateChange(new ConcreteState1(this));
    }

    public Context(State state)
    {
        this.StateChange(state);
    }


    public void StateChange(State state)
    {
        this._state = state;
    }

    public State GetState()
    {
        return this._state;
    }

    public void Operation1()
    {
        this._state.Handle1();
    }

    public void Operation2()
    {
        this._state.Handle2();
    }
}



public abstract class State
{
    protected Context _context;

    public State(Context context)
    {
        SetContext(context);
    }

    public void SetContext(Context context) 
    {
        this._context = context;
    }

    

    public abstract void Handle1();
    public abstract void Handle2();
}

public class ConcreteState1 : State
{
    public ConcreteState1(Context context) : base(context)
    {
    }

    public override void Handle1()
    {
        Console.WriteLine("State1: Handle1");
        _context.StateChange(new ConcreteState2(_context));
    }

    public override void Handle2()
    {
        Console.WriteLine("State1: Handle2");
        
    }
}

public class ConcreteState2 : State
{
    public ConcreteState2(Context context) : base(context)
    {
    }

    public override void Handle1()
    {
        Console.WriteLine("State2: Handle1");
        _context.StateChange(new ConcreteState1(_context));
    }

    public override void Handle2()
    {
        Console.WriteLine("State2: Handle2");
    }
}