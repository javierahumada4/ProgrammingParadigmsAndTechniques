namespace Practice2
{
    class City : IMessageWritter
    {
        private PoliceStation policeStation;
        private List<Taxi> taxis;

        public City()
        {
            policeStation = new PoliceStation();
            taxis = new List<Taxi>();
        }

        public void RegisterTaxi(Taxi taxi)
        {
            taxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()}: Registered license"));
        }

        public void DisableTaxi(string plate)
        {
            foreach(Taxi taxi in taxis)
            {
                if (taxi.GetPlate() == plate)
                {
                    taxis.Remove(taxi);
                    Console.WriteLine(WriteMessage($"Taxi with plate {plate}: Removed license"));
                }
            }
        }

        public string WriteMessage(string message)
        {
            return $"{message}";
        }

    }
}