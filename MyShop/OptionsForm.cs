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
    public partial class OptionsForm : Form
    {
        private Shop _shop;
        public OptionsForm(Shop shop)
        {
            InitializeComponent();
            
            _shop = shop;
            cmbTimeStep.SelectedItem = shop.TimeStep.ToString();
            txtMaxQueryLength.Text = shop.MaxQueryLength.ToString();
            txtByersInMorning.Text = shop.ByersInMorning.ToString();
            txtByersInDay.Text = shop.ByersInDay.ToString();
            txtByersInEvening.Text = shop.ByersInEvening.ToString();
            txtHandlingTimeFrom.Text = shop.HandlingTimeFrom.ToString();
            txtHandlingTimeTo.Text = shop.HandlingTimeTo.ToString();
            txtPatienceTimeFrom.Text = shop.PatienceTimeFrom.ToString();
            txtPatienceTimeTo.Text = shop.PatienceTimeTo.ToString();
            txtByerReceiptsFrom.Text = shop.ByerReceiptsFrom.ToString();
            txtByerReceiptsTo.Text = shop.ByerReceiptsTo.ToString();
            chkDiscountDay.Checked = shop.DiscountDay;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(cmbTimeStep.SelectedItem!=null)
                _shop.TimeStep = int.Parse(cmbTimeStep.SelectedItem.ToString());
            _shop.MaxQueryLength = int.Parse(txtMaxQueryLength.Text);
            _shop.ByersInMorning = int.Parse(txtByersInMorning.Text);
            _shop.ByersInDay = int.Parse(txtByersInDay.Text);
            _shop.ByersInEvening = int.Parse(txtByersInEvening.Text);
            _shop.HandlingTimeFrom = int.Parse(txtHandlingTimeFrom.Text);
            _shop.HandlingTimeTo = int.Parse(txtHandlingTimeTo.Text);
            _shop.PatienceTimeFrom = int.Parse(txtPatienceTimeFrom.Text);
            _shop.PatienceTimeTo = int.Parse(txtPatienceTimeTo.Text);
            _shop.ByerReceiptsFrom = int.Parse(txtByerReceiptsFrom.Text);
            _shop.ByerReceiptsTo = int.Parse(txtByerReceiptsTo.Text);
            _shop.DiscountDay = chkDiscountDay.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }
    }
}
