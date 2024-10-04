using System.Diagnostics.Tracing;

namespace Practice2
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isPursuing;
        private string? pursuingVehiclePlate;
        private IAlertSystem? alertSystem;

        public PoliceCar(string plate, bool radar = false) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isPursuing = false;

            if (radar)
            {
                speedRadar = new SpeedRadar();
            }
        }

        public void RegisterPoliceStation(IAlertSystem alertSystem)
        {
            this.alertSystem = alertSystem;
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (speedRadar != null)  // Check if radar exists
            {
                if (isPatrolling)
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                    if (alertSystem != null)
                    {
                        if (meassurement == "Catched above legal speed.")
                        {
                            alertSystem.ActivateAlert(vehicle.GetPlate());
                        }
                    }
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("has no radar available."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void StartPursuing(string infractorPlate)
        {
            isPursuing = true;
            pursuingVehiclePlate = infractorPlate;
            Console.WriteLine(WriteMessage($"started pursuing vehicle with plate {infractorPlate}."));
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar history available, radar not installed."));
            }
        }
    }
}