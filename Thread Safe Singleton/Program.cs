Singleton singleton1 = Singleton.CreateAsSingleton();
Singleton singleton2 = Singleton.CreateAsSingleton();
singleton1.number = 1;
Console.WriteLine(singleton2.number);
Console.WriteLine(singleton1.number);





class Singleton
{

    private static Singleton _singleton;
    private static readonly object singlelock = new object();
    public int number = 0;

    private Singleton() { }

    public static Singleton CreateAsSingleton()
    {
        lock (singlelock)
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
        }
            return _singleton;

    }
   }
