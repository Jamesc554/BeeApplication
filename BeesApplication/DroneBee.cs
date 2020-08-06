namespace BeesApplication
{
    public class DroneBee : Bee
    {
        public DroneBee()
        {
            DeathLimit = DRONE_DEATH_LIMIT;
        }

        public override string ToString()
        {
            return "Type: Drone, " + base.ToString();
        }
    }
}