namespace Practice2
{
    class City : IMessageWritter
    {
        private PoliceStation? policeStation;
        private List<Taxi> taxis;

        public City()
        {
            taxis = new List<Taxi>();
        }

        public void RegisterPoliceStation(PoliceStation policeStation)
        {
            this.policeStation = policeStation;
        }

        public void RegisterTaxi(Taxi taxi)
        {
            taxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()}: Registered license"));
        }

        public void DisableTaxi(string plate)
        {
            Taxi? removedTaxi = null;
            foreach (Taxi taxi in taxis)
            {
                if (taxi.GetPlate().Contains(plate))
                {
                    removedTaxi = taxi;
                    Console.WriteLine(WriteMessage($"Taxi with plate {plate}: Removed license"));
                }
            }
            if (removedTaxi != null)
            {
                taxis.Remove(removedTaxi);
            }
        }

        public string WriteMessage(string message)
        {
            return $"{message}";
        }

    }
}