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
        //public BindingSource bsCashs = new BindingSource();

        public ShopForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shop.Update();
            dataGridViewCashs.Refresh();
            lblTime.Text = Shop.Time.ToString();
            lblReceipts.Text = Shop.Receipts.ToString();
            lblUnservised.Text = Shop.UnservicedByersCount.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm=new OptionsForm();
            optionsForm.ShowDialog();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            
            dataGridViewCashs.AutoGenerateColumns = false;
            dataGridViewCashs.DataSource = Shop.Cashs;

            timer1.Interval = 100;
            timer1.Enabled = true;
        }
    }
}
