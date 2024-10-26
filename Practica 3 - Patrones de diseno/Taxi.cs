namespace Practice3
{
    using System.Threading;
    public class Taxi
    {
        private static Taxi _instance;
        private int _life;
        private double _speed;
        private int _lastLifeValue;
        private double _lastSpeedValue;

        public int Life { get { return _life; } set { _life = value; } }
        public double Speed { get { return _speed; } set { _speed = value; } }
        public int LastLifeValue { get { return _lastLifeValue; } set { _lastLifeValue = value; } }
        public double LastSpeedValue { get { return _lastSpeedValue; } set { _lastSpeedValue = value; } }

        private Taxi()
        {
            _life = 100;
            _speed = 1.0;
            _lastLifeValue = Life;
            _lastSpeedValue = Speed;
        }

        public static Taxi GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Taxi();
            }
            return _instance;
        }

        public void ApplyObstacleEffect(Obstacle obstacle)
        {
            Life -= obstacle.Damage;
            if (Life < 0 ) { Life = 0; }
            Speed *= obstacle.SpeedMultiplier;

            Thread revertThread = new Thread(() => RevertSpeed(obstacle.SpeedMultiplier, obstacle.EffectDuration));
            revertThread.Start();
        }

        private void RevertSpeed(double speedMultiplier, int effectDuration)
        {
            Thread.Sleep(effectDuration * 1000);
            Speed /= speedMultiplier;
        }

        public void NotifyChanges()
        {
            if (Life != LastLifeValue || Speed != LastSpeedValue)
            {
                Console.WriteLine($"Life: {Life}, Speed: {Speed}");
                LastLifeValue = Life;
                LastSpeedValue = Speed;
            }
        }
    }
}