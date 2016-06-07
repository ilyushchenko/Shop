using System;
using System.Threading;

namespace Shop
{
    public class Buyer
    {
        public Buyer(Shop shop, int buyingTime, int probability)
        {
            m_shop = shop;
            m_buyingTime = buyingTime;
            m_probability = probability;
        }
        
        public void DoShoping()
        {
            // Покупки
            ChooseProducts();
            // Оплата на кассе
            PayInShop(m_shop.ShopCasher);
            // Оплата в каффе
            GoToCaffe(m_shop.CaffeCasher);
            // Выход
            Exit();
        }
         
        private void ChooseProducts()
        {
            m_state = BuyerState.Enter;
            BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
            Thread.Sleep(m_buyingTime);
        }
        
        private void PayInShop(ShopCasher casher)
        {
            m_state = BuyerState.PayEnter;
            BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
            casher.Pay();
            m_state = BuyerState.PayLeave;
            BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
        }
        
        private void GoToCaffe(CaffeCasher casher)
        {
            int value = rnd.Next(101);
            if (value < m_probability)
            {
                m_state = BuyerState.CaffeEnter;
                BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
                casher.Pay();
                m_state = BuyerState.CaffeLeave;
                BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
            }
        }
        
        private void Exit()
        {
            m_state = BuyerState.Leave;
            BuyerStateChengedEvent(this, new BuyerStateEventArgs(m_state));
        }

        public event BuyerStateDelegate BuyerStateChengedEvent;

        private BuyerState m_state;
        private Shop m_shop;
        private int m_buyingTime;
        private int m_probability;
        private static Random rnd = new Random(DateTime.Now.Millisecond);
    }
}
