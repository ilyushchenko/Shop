using System;
using System.Threading;

namespace Shop
{
    class ShopControl
    {
        private enum ShopState
        {
            Open,
            Close
        }

        public ShopControl(Shop shop, DateTime openTime, DateTime closeTime, int maxCount)
        {
            m_openTime = openTime;
            m_closeTime = closeTime;
            m_currentTime = m_openTime;
            m_shop = shop;
            m_maxCount = maxCount;
        }

        public void Tick(double minutes)
        {
            m_currentTime = m_currentTime.AddMinutes(minutes);
            if (m_currentTime.TimeOfDay >= m_openTime.TimeOfDay && m_currentTime.TimeOfDay < m_closeTime.TimeOfDay)
            {
                m_state = ShopState.Open;
            }
            else
            {
                m_state = ShopState.Close;
            }
        }

        public void GenerateBuyer(int buyingTime, int probability)
        {
            
            if (m_state == ShopState.Open && m_total < m_maxCount)
            {
                Buyer buyer = new Buyer(m_shop, buyingTime, probability);
                Thread buyerThread = new Thread(buyer.DoShoping);
                buyer.BuyerStateChengedEvent += UpdateData;
                buyerThread.Start();
            }
        }

        private void UpdateData(object sendler, BuyerStateEventArgs e)
        {
            switch (e.State)
            {
                case BuyerState.Enter:
                    Interlocked.Increment(ref m_total);
                    break;
                case BuyerState.PayEnter:
                    Interlocked.Increment(ref m_inCashers);
                    break;
                case BuyerState.PayLeave:
                    Interlocked.Decrement(ref m_inCashers);
                    break;
                case BuyerState.CaffeEnter:
                    Interlocked.Increment(ref m_inCaffe);
                    break;
                case BuyerState.CaffeLeave:
                    Interlocked.Decrement(ref m_inCaffe);
                    break;
                case BuyerState.Leave:
                    Interlocked.Decrement(ref m_total);
                    break;
            }
            UpdateEvent(this, new UpdateStateEventArgs(m_total, m_inCashers, m_inCaffe));
        }

        public event UpdateDelegate UpdateEvent;

        private DateTime m_openTime;
        private DateTime m_closeTime;
        private DateTime m_currentTime;
        private Shop m_shop;

        private int m_total = 0;
        private int m_inCashers = 0;
        private int m_inCaffe = 0;
        private int m_maxCount = 0;

        private ShopState m_state = ShopState.Open;
    }

    
}
