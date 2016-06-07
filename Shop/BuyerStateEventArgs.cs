namespace Shop
{
    public enum BuyerState
    {
        Enter,
        PayEnter,
        PayLeave,
        CaffeEnter,
        CaffeLeave,
        Leave
    }

    public delegate void BuyerStateDelegate(object sendler, BuyerStateEventArgs e);

    public class BuyerStateEventArgs
    {
        public BuyerStateEventArgs(BuyerState state)
        {
            State = state;
        }

        public BuyerState State { get; private set; }
    }
}
