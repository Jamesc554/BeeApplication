namespace BeesApplication
{
    public class QueenBee : Bee
    {
        public QueenBee()
        {
            DeathLimit = QUEEN_DEATH_LIMIT;
        }

        public override string ToString()
        {
            return "Type: Queen, " + base.ToString();
        }
    }
}