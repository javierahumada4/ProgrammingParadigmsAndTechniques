namespace Practice2
{
    class Scooter : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle)
        {
            
        }
    }
}