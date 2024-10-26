namespace Practice3
{    
    internal class Program
    {   
        static void Main()
        {
            Taxi taxi = Taxi.GetInstance();
            PoliceCarFactory policeCarFactory = new PoliceCarFactory();
            ConstructionFenceFactory constructionFenceFactory = new ConstructionFenceFactory();
            SpeedDebuffFactory speedDebuffFactory = new SpeedDebuffFactory();

            Console.WriteLine("Press a key to create an obstacle: ");
            Console.WriteLine("     A -> PoliceCar");
            Console.WriteLine("     S -> ConstructionFence");
            Console.WriteLine("     D -> SpeedDebuff");

            while (taxi.Life > 0)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true).KeyChar;
                    Obstacle? obstacle = null;
                    switch (char.ToUpper(key))
                    {
                        case 'A':
                            obstacle = policeCarFactory.CreateObstacle();
                            break;
                        case 'S':
                            obstacle = constructionFenceFactory.CreateObstacle();
                            break;
                        case 'D':
                            obstacle = speedDebuffFactory.CreateObstacle();
                            break;
                        default:
                            break;
                    }
                    if (obstacle != null)
                    {
                        taxi.ApplyObstacleEffect(obstacle);
                    }
                }
                taxi.NotifyChanges();
                Thread.Sleep(20);
            }
        }
    }
}