﻿namespace Practice3
{
    public class SpeedDebuffFactory : ObstacleFactory
    {
        public override Obstacle CreateObstacle()
        {
            return new SpeedDebuff();
        }
    }
}