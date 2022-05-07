using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace NT106_Lab3
{
    public partial class frmVd1_Client : Form
    {
        public frmVd1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // initialize variable ip endpoint and Udpclient
            UdpClient udpClient = new UdpClient();
            IPAddress IpAdd = IPAddress.Parse(tbIP.Text);
            IPEndPoint EPHost = new IPEndPoint(IpAdd, 8080);
            
            //data
            Byte[] data = Encoding.ASCII.GetBytes("Hello world!");
            
            //send
            udpClient.Send(data, data.Length, EPHost);
        }
    }
}
