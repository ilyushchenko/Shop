namespace Shop
{
    public class Shop
    {
        public Shop(ShopCasher shopCasher, CaffeCasher caffeCasher)
        {
            CaffeCasher = caffeCasher;
            ShopCasher = shopCasher;
        }

        public ShopCasher ShopCasher { get; private set; }
        public CaffeCasher CaffeCasher { get; private set; }
    }
}
