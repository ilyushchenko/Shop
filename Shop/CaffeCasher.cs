using System.Threading;

namespace Shop
{
    public class CaffeCasher : Casher
    {
        public CaffeCasher(int time) : base(time) { }
        public override void Pay()
        {
            lock (casher)
            {
                Thread.Sleep(m_time);
            }
        }
        
        private object casher = new object();
    }
}