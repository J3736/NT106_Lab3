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
using System.Threading;

namespace NT106_Lab3
{
    public partial class frmB1_Server : Form
    {
        public frmB1_Server()
        {
            InitializeComponent();
        }

        void serverThread()
        {
            int Port = Convert.ToInt16(tbPort.Text);
            UdpClient udpClient = new UdpClient(Port);

            IPEndPoint IPEP = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                
                byte[] BytesReceive = udpClient.Receive(ref IPEP);
                string mess = Encoding.ASCII.GetString(BytesReceive);
                string rtbmess = IPEP.Address.ToString() + ": " +
                    mess + "\n";
                rtbMess.AppendText(rtbmess);
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            tbPort.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread server_Thread = new Thread(new ThreadStart(serverThread));
            server_Thread.IsBackground = true;
            server_Thread.Start();
        }
    }
}
