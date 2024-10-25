namespace Practice3
{
    public abstract class Obstacle
    {
        protected bool _isFollowing;
        protected bool _isSolid;
        protected int _damage;
        protected double _speedMultiplier;
        protected int _effectDuration;

        public bool IsFollowing { get { return _isFollowing; } set { _isFollowing = value; } }
        public bool IsSolid { get { return _isSolid; } set { _isSolid = value; } }
        public int Damage { get { return _damage; } }
        public double SpeedMultiplier { get { return _speedMultiplier; } }
        public int EffectDuration { get { return _effectDuration; } }
    }
}
