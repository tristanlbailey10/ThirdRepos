using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        int mDiscount = 0;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void chkSDiscount_Click(object sender, EventArgs e)
        {
            if (chkChildDiscount.Checked) chkChildDiscount.Checked = false;
        }

        private void chkChildDiscount_Click(object sender, EventArgs e)
        {
            if (chkSDiscount.Checked) chkSDiscount.Checked = false;
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                mQuantity = int.Parse(txtQuantity.Text);
            }
            else
            {
                mQuantity = 0;
            }

            //if (chkDiscount.Checked)
            //    { mDiscount = true; }
            //mDiscount = chkSDiscount.Checked;
            if (chkSDiscount.Checked)
            {
                mDiscount = 1;
            }
            else if (chkChildDiscount.Checked)
            {
                mDiscount = 2;
            }
            else
            {
                mDiscount = 0;
            }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount);

            mTicketPrice.calculatePrice();
            //lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
            lblAmount.Text = mTicketPrice.AmountDue.ToString("0.00");
        }
    }
}
