EvenHandler evenHandler = new EvenHandler();
OddHandler oddHandler = new OddHandler();   
evenHandler.SetNext(oddHandler);
Console.WriteLine(evenHandler.Handle(3)); 


public interface IHandler
{
    public IHandler SetNext(IHandler handler);
    public Object Handle(object request);
}

public abstract class AbstractHandler : IHandler
{
    protected IHandler Handler;

    public virtual object Handle(object request)
    {
        if(Handler != null)
        {
            return Handler.Handle(request);
        }
        else
        {
            return null;
        }
    }

    public IHandler SetNext(IHandler handler)
    {
        this.Handler = handler;
        return handler;
    }
}


public class EvenHandler:AbstractHandler
{
    public override object Handle(object request)
    {
        if((int)request%2==0) 
            return "Handled By Even Handler";

        else 
            return Handler.Handle(request);
    }
}

public class OddHandler:AbstractHandler
{
    public override object Handle(object request)
    {
        if ((int)request % 2 != 0)
            return "Handled By Odd Handler";

        else
            return Handler.Handle(request);
    }
}