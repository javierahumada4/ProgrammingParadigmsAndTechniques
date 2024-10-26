namespace Practice3
{
    public class ConstructionFence : Obstacle
    {
        public ConstructionFence()
        {
            _isFollowing = false;
            _isSolid = true;
            _damage = 10;
            _speedMultiplier = 0.8;
            _effectDuration = 60;
        }
    }
}
