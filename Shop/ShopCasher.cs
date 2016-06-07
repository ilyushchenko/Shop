using System.Threading;

namespace Shop
{
    public class ShopCasher : Casher
    {
        public ShopCasher(int time, int totalCount) : base(time)
        {
            m_shopCashers = new Semaphore(totalCount, totalCount);
        }
        
        public override void Pay()
        {
            m_shopCashers.WaitOne();
            Thread.Sleep(m_time);
            m_shopCashers.Release();
        }
        
        private Semaphore m_shopCashers;
    }
}