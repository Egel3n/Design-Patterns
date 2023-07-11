
Alarm alarm1 = new Alarm(new TelephoneAlarm());
Alarm alarm2 = new Alarm(new ClockAlarmAdapter());

alarm1.Run();
alarm2.Run();


class Alarm
{
    IAlarm alarm;
    public Alarm(IAlarm alarm)
    {
        this.alarm = alarm;
    }

    public void Run()
    {
        alarm.Beep();
    }
}



interface IAlarm
{
    void Beep();
}

class TelephoneAlarm : IAlarm
{
    public void Beep()
    {
        Console.WriteLine("Telephone Ringing");
    }
}


//lets assume that we import the below code from somewhere else

class ClockAlarm
{
    public void Noise()
    {
        Console.WriteLine("Clock Making Noise");
    }
}


class ClockAlarmAdapter:IAlarm
{
    ClockAlarm clock = new ClockAlarm();
    
    public void Beep()
    {
        clock.Noise();  
    }
}