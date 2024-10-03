public class Radar
{
    private const int maxLegalSpeed = 50;
    private List<int> _speedHistory;

    public Radar()
    {
        _speedHistory = new List<int>();
    }

    public List<int> SpeedHistory
    {
        get { return _speedHistory; }
    }

    public void AddToSpeedHistory(int speed)
    {
        _speedHistory.Add(speed);
    }

    public string Trigger(Car c)
    {
        int carSpeed = c.Speed;
        AddToSpeedHistory(carSpeed);
        string report = "";
        if (carSpeed > maxLegalSpeed)
        {
            report = "Catchet above legal speed";
        }
        else
        {
            report = "Driving legally";
        }

        return $"Result: Vehicle with plate {c.Plate} at {carSpeed} km/h. {report}";
    }
}