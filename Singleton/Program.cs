
Singleton singleton1 = Singleton.CreateAsSingleton();
Singleton singleton2 = Singleton.CreateAsSingleton();
singleton1.number = 1;
Console.WriteLine(singleton2.number);
Console.WriteLine(singleton1.number);



class Singleton
{
    private Singleton() { }
    static Singleton _singleton;
    public int number = 0;
    
    public static Singleton CreateAsSingleton() { 
        
        if(_singleton == null)
        {
            _singleton = new Singleton();
        }
        return _singleton;
    }

}



