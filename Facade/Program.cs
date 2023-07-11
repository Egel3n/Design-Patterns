MainProject main = new MainProject();
main.Do();



public class Useful1
{
    public void Do1()
    {
        Console.WriteLine("doing something1");
    }
}

public class Useful2
{
    public void Do2()
    {
        Console.WriteLine("doing something2");
    }
}

public class Useful3
{
    public void Do3()
    {
        Console.WriteLine("doing something3");
    }
}


public class Facade
{
    public Useful1 useful1 = new Useful1();
    public Useful2 useful2 = new Useful2();
    public Useful3 useful3 = new Useful3();


}

class MainProject
{ 
    Facade facades = new Facade();
    public void Do()
    {
        facades.useful1.Do1 ();
        facades.useful2.Do2 ();
        facades.useful3.Do3 ();
    }



}