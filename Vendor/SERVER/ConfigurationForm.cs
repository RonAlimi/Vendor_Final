using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vendor.SERVER
{
    public partial class ConfigurationForm : Form
    {
        Vendor_BAL balObj;

        public ConfigurationForm()
        {
            InitializeComponent();
            balObj = new Vendor_BAL();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            this.txtLoacalIp.Text = balObj.GetLocalIp();
            this.txtLocalPort.Text = balObj.LocalPort.ToString();
        }
    }
}
