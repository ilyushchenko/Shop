namespace Shop
{
    public abstract class Casher
    {
        public Casher(int time)
        {
            m_time = time;
        }
        protected int m_time;
        public abstract void Pay();
    }
}