namespace Practice2
{
    class PoliceStation : IMessageWritter
    {
        private List<PoliceCar> policeCars;
        private bool alert;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            alert = false;
        }

        public void RegisterPoliceCar(string plate)
        {
            PoliceCar newPoliceCar = new PoliceCar(plate);
            policeCars.Add(newPoliceCar);
            Console.WriteLine(WriteMessage($"Police Car with plate {plate}: Registered in the Police Station"));
        }

        public void ActivateAlert(string infractorPlate)
        {
            alert = true;

            foreach (PoliceCar policeCar in policeCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.StartPursuing(infractorPlate);
                }
            }

            Console.WriteLine(WriteMessage($"Infractor vehicle with plate {infractorPlate}: Alert Activated. All units in patroll start pursuing."));
        }

        public void DeactivateAlert(string infractorPlate)
        {
            alert = false;

            foreach (PoliceCar policeCar in policeCars)
            {
                policeCar.StopPursuing(infractorPlate);
            }

            Console.WriteLine(WriteMessage($"Infractor vehicle with plate {infractorPlate}: Alert Deactivated. All units in patroll stop pursuing."));
        }

        public string WriteMessage(string message)
        {
            return $"{message}";
        }

    }
}