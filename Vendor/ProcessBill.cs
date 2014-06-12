using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vendor
{
    public partial class ProcessBill : UserControl
    {
        Vendor_BAL obj = new Vendor_BAL();

        public ProcessBill()
        {
            InitializeComponent();

            cbProducts.DataSource = obj.GetProductNames();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtItemPrice.Text) * Convert.ToDouble(txtQty.Text);
            lblTotal.Text = string.Format(
                "\t{0}\nX\t{1}\n__________________\nTOTAL: {2}",
                txtQty.Text,txtItemPrice.Text,total
                );
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemPrice.Text = obj.GetProductPrice(cbProducts.SelectedText);
        }
    }
}
