using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;

namespace Vendor.SERVER
{
    public partial class ServerForm : Form
    {
        //networking objects
        Socket socket;
        EndPoint local;
        EndPoint remote;
        byte[] buffer;



        Vendor_BAL balObj;

        public ServerForm()
        {
            InitializeComponent();

            balObj = new Vendor_BAL();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //bind socket
            local = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), balObj.LocalPort);
            socket.Bind(local);
            statusLbl.Text = "Connected to remote host.";

            //connect to remote client
            remote = new IPEndPoint(IPAddress.Parse(txtIpRemote.Text), Convert.ToInt16(txtRemotePort.Text));
            socket.Connect(remote);

            //start listening
            buffer = new byte[1024];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult ar)
        {
            byte[] receiveData = new byte[1024];
            receiveData = (byte[])ar.AsyncState;
            string message = Encoding.Default.GetString(receiveData);

            if (lstNotifications.InvokeRequired)
            {
                lstNotifications.Invoke((MethodInvoker)delegate()
                {
                    TransferText(message);
                });
            }
            else
                lstNotifications.Items.Add(message);

            buffer = new byte[1024];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            ALGENT.Grupi_Algent_ServiceSoapClient algObj = new ALGENT.Grupi_Algent_ServiceSoapClient();

            txtLocalIp.Text = balObj.GetLocalIp();
            txtPortLocal.Text = balObj.LocalPort.ToString();
            txtIpRemote.Text = balObj.GetLocalIp();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            this.cbProducts.DataSource = algObj._stock_products();
            cbProducts.DisplayMember = "name";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] senData = new byte[1024];
            senData = Encoding.Default.GetBytes(txtMessage.Text);
            //send
            socket.Send(senData);
            lstNotifications.Items.Add("<server> " + txtMessage.Text);
            txtMessage.Text = null;

            statusLbl.Text = "Message is sent";
        }


        #region Cross - thread

        public void TransferText(string text)
        {
            lstNotifications.Items.Add(string.Format(
                "<client> asked: {0}\t received at {1}",
                text,DateTime.Now.ToLocalTime().ToString()
                ));
        }

        #endregion

        public void ShippStock()
        {
            //consume web method to add stock in azure database
        }

   
    

        #region Methods

        private void btnAddReq_Click(object sender, EventArgs e)
        {
            try
            {
                string product = cbProducts.SelectedItem.ToString();
                int qty = Convert.ToInt16(txtQty.Text);
                statusLbl.Text = balObj.AddToRequestLog(txtCustomer.Text, "Cola Zero", qty);
            }
            catch (FormatException)
            {
                statusLbl.Text = "Quantity should be integer";
            }
              
            /*
            string product = cbProducts.SelectedValue.ToString();
            int qty = Convert.ToInt16(txtQty.Text);
            string description = "default description";

            UPDATESTOCK.WS_UpdateStockSoapClient proxy = new UPDATESTOCK.WS_UpdateStockSoapClient();
            statusLbl.Text = proxy.UpdateStockWith(product, qty, description);


            //statusLbl.Text = balObj.AddToRequestLog(txtCustomer.Text, cbProducts.SelectedValue.ToString(), Convert.ToInt32(txtQty.Text));
            */
        }

        #endregion
    }
}
