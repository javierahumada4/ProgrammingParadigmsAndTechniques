using System.Diagnostics.Tracing;

namespace Practice2
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isPursuing;
        private string? pursuingVehiclePlate;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();
            isPursuing = false;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (speedRadar != null)  // Check if radar exists
            {
                if (isPatrolling)
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                    if (meassurement == "Catched above legal speed.")
                    {

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