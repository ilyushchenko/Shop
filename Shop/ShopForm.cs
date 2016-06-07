using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopForm : Form
    {
        private ShopControl shopControl;

        private UpdateDelegate m_updater;

        public ShopForm()
        {
            InitializeComponent();
            m_updater = new UpdateDelegate(UpdateInfo);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ShopCasher shopCasger = new ShopCasher(int.Parse(tbxCasher.Text), int.Parse(tbxCount.Text));
            CaffeCasher caffeCasher = new CaffeCasher(int.Parse(tbxCaffe.Text));
            Shop shop = new Shop(shopCasger, caffeCasher);
            shopControl = new ShopControl(shop, dtpOpen.Value, dtpClose.Value, int.Parse(tbxMaxCount.Text));
            shopControl.UpdateEvent += UpdateInfo;
        }

        public void UpdateInfo(object sendler, UpdateStateEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(m_updater, sendler, e);
            }
            else
            {
                labelInShop.Text = e.Total.ToString();
                labelInCashers.Text = e.InShop.ToString();
                labelInCaffe.Text = e.InCaffe.ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            shopControl.Tick(trackBarTime.Value);
            shopControl.GenerateBuyer(int.Parse(tbxShopTime.Text), int.Parse(tbxProbability.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
