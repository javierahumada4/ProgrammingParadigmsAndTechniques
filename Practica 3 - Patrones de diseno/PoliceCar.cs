namespace Practice3
{
    public class PoliceCar: Obstacle
    {
        public PoliceCar()
        {
            _isFollowing = true;
            _isSolid = true;
            _damage = 30;
            _speedMultiplier = 0.8;
            _effectDuration = 60;
        }

        public override void EffectOnTaxi(Taxi taxi)
        {

        }
    }

