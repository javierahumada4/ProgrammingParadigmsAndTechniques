﻿namespace Practice3
{
    public class PoliceCarFactory: ObstacleFactory
    {
        public override Obstacle CreateObstacle()
        {
            return new PoliceCar();
        }
    }
}
