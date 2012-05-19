using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyShop
{
    public partial class ShopForm : Form
    {
        public Shop Shop=new Shop();

        public ShopForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            dataGridViewCashs.DataSource = Shop.Cashs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shop.Update();
            lblTime.Text = Shop.Time.ToString();
            lblReceipts.Text = Shop.Receipts.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm=new OptionsForm();
            optionsForm.ShowDialog();
        }
    }
}
