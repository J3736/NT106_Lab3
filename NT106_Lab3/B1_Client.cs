using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace NT106_Lab3
{
    public partial class frmB1_Client : Form
    {
        public frmB1_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            int port = Convert.ToInt16(tbPort.Text);
            string IP = tbIP.Text;
            IPEndPoint IPEP = new IPEndPoint(IPAddress.Parse(IP), port);


            Byte[] BytesSend = Encoding.ASCII.GetBytes(tbMess.Text);

            udpClient.Send(BytesSend, BytesSend.Length, IPEP);
        }

        private void frmB1_Client_Load(object sender, EventArgs e)
        {
            
        }
    }
}
