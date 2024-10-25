namespace Practice3
{
    public class Fence : Obstacle
    {
        public Fence()
        {
            _isFollowing = false;
            _isSolid = true;
            _damage = 10;
            _speedMultiplier = 0.8;
            _effectDuration = 60;
        }

        public override void EffectOnTaxi(Taxi taxi)
        {
            
        }
    }

