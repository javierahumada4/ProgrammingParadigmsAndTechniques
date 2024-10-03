public class Taxi : Car
{
    private const int defaultSpeed = 45;
    private const int rideSpeed = 100;

    public Taxi(string plate) : base(plate)
    {
        _tipe = "Taxi";
        _speed = defaultSpeed;
    }

    public void TakePassengers()
    {
        ManageFlag(true, "starts a ride", "is already in a ride");
        Speed = rideSpeed;
    }

    public void LeavePassengers()
    {
        ManageFlag(false, "finishes a ride", "is not on a ride");
        Speed = defaultSpeed;
    }
}