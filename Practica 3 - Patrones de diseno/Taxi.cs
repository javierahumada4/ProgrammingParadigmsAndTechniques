namespace Practice3
{
    public class Taxi:
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

        public void ApplyEffect(Obstacle obstacle)
        {

        }
    }
}