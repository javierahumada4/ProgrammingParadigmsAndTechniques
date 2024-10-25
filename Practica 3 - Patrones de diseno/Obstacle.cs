namespace Practice3
{
    public abstract class Obstacle
    {
        protected bool _isFollowing;
        protected bool _isSolid;
        protected int _damage;
        protected double _speedMultiplier;
        protected int _effectDuration;

        public bool IsFollowing { get { return _isFollowing; } set { _isFollowing = true; } }
        public bool IsSolid { get { return _isSolid; } set { _isSolid = true; } }
        public int Damage { get { return _damage; } }
        public double SpeedMultiplier { get { return _speedMultiplier; } }
        public int EffectDuration { get { return _effectDuration; } }

        public abstract void EffectOnTaxi(Taxi taxi);
    }
}
