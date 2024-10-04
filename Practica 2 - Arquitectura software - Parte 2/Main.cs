namespace Practice2
{
    internal class Program
    {

        static void Main()
        {
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");

            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));

            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

            City city = new City();
            PoliceStation policeStation = new PoliceStation();
            city.RegisterPoliceStation(policeStation);

            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);

            PoliceCar policeCarRadar1 = new PoliceCar("0003 CNP", true);
            PoliceCar policeCarRadar2 = new PoliceCar("0004 CNP", true);

            policeStation.RegisterPoliceCar(policeCar1);
            policeStation.RegisterPoliceCar(policeCar2);
            policeStation.RegisterPoliceCar(policeCarRadar1);
            policeStation.RegisterPoliceCar(policeCarRadar2);

            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            policeCarRadar1.StartPatrolling();
            policeCarRadar1.UseRadar(taxi1);

            city.DisableTaxi("0001 AAA");

        }
    }
}
    

