namespace Practice2
{
    class PoliceStation : IMessageWritter, IAlertSystem
    {
        private List<PoliceCar> policeCars;
        private bool alert;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            alert = false;
        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            policeCar.RegisterPoliceStation(this);
            policeCars.Add(policeCar);
            Console.WriteLine(WriteMessage($"Police Car with plate {policeCar.GetPlate()}: Registered in the Police Station"));
        }

        public void ActivateAlert(string infractorPlate)
        {
            alert = true;

            Console.WriteLine(WriteMessage($"Infractor vehicle with plate {infractorPlate}: Alert Activated. All units in patroll start pursuing."));

            foreach (PoliceCar policeCar in policeCars)
            {
                if (policeCar.IsPatrolling())
                {
                    policeCar.StartPursuing(infractorPlate);
                }
            }         
        }

        public string WriteMessage(string message)
        {
            return $"{message}";
        }

    }
}