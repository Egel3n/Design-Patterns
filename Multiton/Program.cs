public class Multiton
{
    private static object _lock = new object();
    private static Multiton _instance;
    private static Dictionary<string, Multiton> _multitonKeys;

    public static Multiton GetInstance(string str)
    {
        lock( _lock)
        {
            if (!_multitonKeys.ContainsKey(str))
            {
                _multitonKeys[str] = new Multiton();
            }
            return _multitonKeys[str];
        }
    }


    private Multiton() { }

}
