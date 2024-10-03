public abstract class Car
{
    protected string _tipe;
    protected string _plate;
    protected int _speed;
    protected bool _flag;

    public Car(string plate)
    {
        _plate = plate;
    }

    public string Tipe
    {
        get { return _tipe; }
        protected set { _tipe = value; }
    }

    public string Plate
    {
        get { return _plate; }
    }

    public int Speed
    {
        get { return _speed; }
        protected set { _speed = value; }
    }

    public bool Flag
    {
        get { return _flag; }
        protected set { _flag = value; }
    }

    protected void ManageFlag (bool newStatus, string successMessage, string failureMessage)
    {
        if (Flag != newStatus)
        {
            Flag = newStatus;
            PrintMessage(successMessage);
        }
        else
        {
            PrintMessage(failureMessage);
        }
    }

    protected void PrintMessage(string message)
    {
        Console.WriteLine($"{Tipe} with plate {Plate}: {message}.");
    }

    public void ToString()
    {
        PrintMessage("Created");
    }

}
