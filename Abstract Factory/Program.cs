var afac = new ASUSFactory();
afac.ProduceGPU();
afac.ProduceMonitor();
var msifac = new MSIFactory();
msifac.ProduceGPU();
msifac.ProduceMonitor();
 

public interface GPU
{
    void getHeat();
}

public interface Monitor
{
    void display();
}

class MSIgpu : GPU
{
    public void getHeat()
    {
        Console.WriteLine("MSI got heat");
    }
}

class ASUSgpu : GPU
{
    public void getHeat()
    {
        Console.WriteLine("ASUS got heat");
    }
}

class MSImonitor : Monitor
{
    public void display()
    {
        Console.WriteLine("MSI displayed");
    }
}

class ASUSmonitor:Monitor
{
    public void display()
    {
        Console.WriteLine("ASUS displayed");
    }
}

public abstract class MainFactory
{

    public abstract Monitor MonitorFactoryMethod();
    public abstract GPU GPUFactoryMethod();


    public void ProduceMonitor()
    {
        var _monitor = MonitorFactoryMethod();
        _monitor.display();
    }

    public void ProduceGPU() {
        var _gpu = GPUFactoryMethod();
        _gpu.getHeat();
    }
}

public class MSIFactory : MainFactory
{
    public override GPU GPUFactoryMethod()
    {
        return new MSIgpu();
    }

    public override Monitor MonitorFactoryMethod()
    {
        return new MSImonitor();
    }
}

public class ASUSFactory : MainFactory
{
    public override GPU GPUFactoryMethod()
    {
        return new ASUSgpu();
    }

    public override Monitor MonitorFactoryMethod()
    {
        return new ASUSmonitor();
    }
}