namespace Practice3
{
    public class Debuffer : Obstacle
    {
        public Debuffer()
        {
            _isFollowing = false;
            _isSolid = false;
            _damage = 0;
            _speedMultiplier = 0.5;
            _effectDuration = 30;
        }
    }
}