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
        private DateTime GridLastRefreshTime=DateTime.Now;

        public ShopForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shop.Update();

            //обновление грида не чаще чем раз в секунду. Избавляет от мерцания и разгружает процессор
            if (DateTime.Now - GridLastRefreshTime >= new TimeSpan(0,0,1))
            {
                dataGridViewCashs.Refresh();
                GridLastRefreshTime = DateTime.Now;
            }

            lblTime.Text = Shop.Time.ToString();
            lblReceipts.Text = Shop.Receipts.ToString();
            lblUnservised.Text = Shop.UnservicedByersCount.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm=new OptionsForm(Shop);
            if(optionsForm.ShowDialog()==DialogResult.OK)
                ApplySettings();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(Shop);
            optionsForm.ShowDialog();
            ApplySettings();

            dataGridViewCashs.AutoGenerateColumns = false;
            dataGridViewCashs.DataSource = Shop.Cashs;

            timer1.Enabled = true;
        }

        /// <summary>
        /// Обновление информации главного окна программы
        /// </summary>
        private void ApplySettings()
        {
            timer1.Interval = 1000 / Shop.TimeStep;
            lblTimeStep.Text = Shop.TimeStep.ToString();
            lblByersInMorning.Text = Shop.ByersInMorning.ToString();
            lblByersInDay.Text = Shop.ByersInDay.ToString();
            lblByersInEvening.Text = Shop.ByersInEvening.ToString();
        }
    }
}
