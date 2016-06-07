namespace Shop
{
    public delegate void UpdateDelegate(object sendler, UpdateStateEventArgs e);

    public class UpdateStateEventArgs
    {
        public UpdateStateEventArgs(int total, int inShopCasher, int inCaffeCasher)
        {
            Total = total;
            InShop = inShopCasher;
            InCaffe = inCaffeCasher;
        }

        public int Total { get; private set; }
        public int InShop { get; private set; }
        public int InCaffe { get; private set; }
    }
}
