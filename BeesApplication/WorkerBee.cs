namespace BeesApplication
{
    public class WorkerBee : Bee
    {
        public WorkerBee()
        {
            DeathLimit = WORKER_DEATH_LIMIT;
        }

        public override string ToString()
        {
            return "Type: Worker, " + base.ToString();
        }
    }
}