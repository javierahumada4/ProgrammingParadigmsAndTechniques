using System;

class Program
{
    static void Main(string[] args)
    {
        Taxi taxi1 = new Taxi("0001 AAA");
        taxi1.ToString();
        Taxi taxi2 = new Taxi("0002 BBB");
        taxi2.ToString();
        PoliceCar policeCar1 = new PoliceCar("0001 CNP");
        policeCar1.ToString();
        PoliceCar policeCar2 = new PoliceCar("0002 CNP");
        policeCar2.ToString();
        policeCar1.StartPatrol();
        policeCar1.TriggerRadar(taxi1);
        taxi2.TakePassengers();
        policeCar2.TriggerRadar(taxi2);
        policeCar2.StartPatrol();
        policeCar2.TriggerRadar(taxi2);
        taxi2.LeavePassengers();
        policeCar2.StopPatrol();
        taxi1.TakePassengers();
        taxi1.TakePassengers();
        policeCar1.StartPatrol();
        policeCar1.TriggerRadar(taxi1);
        taxi1.LeavePassengers();
        taxi1.LeavePassengers();
        policeCar1.StopPatrol();
        policeCar1.ReportRadarHistory();
        policeCar2.ReportRadarHistory();
    }
}
