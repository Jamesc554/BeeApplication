using System;

namespace BeesApplication
{
    public class Bee
    {
        #region Constants

        public static float START_HEALTH = 100;
        public static float WORKER_DEATH_LIMIT = 0.7f;
        public static float QUEEN_DEATH_LIMIT = 0.2f;
        public static float DRONE_DEATH_LIMIT = 0.5f;

        #endregion

        #region Properites
        
        private float _health;
        public float Health
        {
            get => _health;
            private set => _health = value < 0 ? 0 : value;
        }
        
        private float _deathLimit;
        protected float DeathLimit
        {
            get => _deathLimit;
            set => _deathLimit = value;
        }
        public bool IsDead => (Health < (START_HEALTH * DeathLimit));

        #endregion

        public Bee()
        {
            Health = 100;
        }

        public void Damage(int amount)
        {
            // If the inputted value is not within bounds.
            if (amount < 0 || amount > 100)
            {
                throw new ArgumentOutOfRangeException("The inputted field {amount} was not within the correct bounds." +
                                            " Must be between 0-100");
            }
            
            // If the bee is already dead.
            if (IsDead)
            {
                return;
            }

            Health -= amount;
        }

        public override string ToString()
        {
            return $"Health: {Health}, IsDead: {IsDead}";
        }
    }
}