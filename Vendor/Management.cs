using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Vendor.SERVER;

namespace Vendor
{
    public partial class Management : Form
    {
        Vendor_BAL balObj;
        ProcessBill ucontrol;
        public Management()
        {
            InitializeComponent();
            balObj = new Vendor_BAL();
            ucontrol = new ProcessBill();

            searchResultGrid.DataSource = balObj.InitGridSearch().Tables[0];
            statusLbl.Text = "Ready";
        }


        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configWindow = new ConfigurationForm();
            configWindow.ShowDialog();
        }

        private void mstripServerConnect_Click(object sender, EventArgs e)
        {
            ServerForm srv = new ServerForm();
            srv.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(balObj.AddNewProduct(txtAddCode.Text, txtAddName.Text, Convert.ToDouble(txtAddCost.Text), Convert.ToInt32(txtQty.Text)));
            statusLbl.Text = "";

            txtAddCode.Text = "";
            txtAddName.Text = "";
            txtAddCost.Text = "";
            txtQty.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            statusLbl.Text = balObj.EditProduct(txtEditID.Text, txtEditName.Text, Convert.ToDouble(txtEditCost.Text));

            txtEditID.Text = "";
            txtEditName.Text = "";
            txtEditCost.Text = "";
        }


        private void btnShip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells[0].Value);
                string prodId = Convert.ToString(selectedRow.Cells[1].Value);
                int qty = Convert.ToInt32(selectedRow.Cells[4].Value);
                statusLbl.Text = balObj.ProcessRequest(Convert.ToInt32(id));

                MessageBox.Show(balObj.UpdateStockWithProduct(prodId,qty));
            }


        }


        #region TOOL STRIP BUTTON EVENTS

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = balObj.GetAllRequests().Tables[0];
            btnShip.Visible = true;


            statusLbl.Text = "Select a row to process...";
        }

        private void toolStripButtonLOAD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = balObj.GetAllProducts().Tables[0];
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = balObj.GetAllRequests().Tables[0];
        }
        private void toolStripButtonLoadBills_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = balObj.GetInvoices().Tables[0];
        }

        #endregion












    }
}
