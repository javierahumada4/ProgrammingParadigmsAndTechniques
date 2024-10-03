public class PoliceCar : Car
{
    private Radar _radar;

    public PoliceCar(string plate) : base(plate)
    {
        _tipe = "Police Car";
        _speed = 0;
        _radar = new Radar();
    }

    public void StartPatrol()
    {
        ManageFlag(true, "started patrolling", "is already patrolling");
    }

    public void StopPatrol()
    {
        ManageFlag(false, "stopped patrolling", "is not patrolling");
    }

    public void TriggerRadar(Car c)
    {
        if (Flag)
        {
            string radarReport = _radar.Trigger(c);
            PrintMessage($"Triggered radar. {radarReport}");
        }
        else
        {
            PrintMessage("has no active radar");
        }
    }

    public void ReportRadarHistory()
    {
        PrintMessage($"Report radar history: ");

        foreach (int speed in _radar.SpeedHistory)
        {
            Console.WriteLine(speed);
        }
    }
}
