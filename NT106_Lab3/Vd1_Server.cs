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
    public partial class frmVd1_Server : Form
    {
        public frmVd1_Server()
        {
            InitializeComponent();
        }

        void serverThread()
        {
            UdpClient udpClient = new UdpClient();

            // endpoint receive
            IPEndPoint RemoteIPEP = new IPEndPoint(IPAddress.Any, 8080);
            udpClient.Client.Bind(RemoteIPEP);

            while (true)
            {
               
                byte[] data = udpClient.Receive(ref RemoteIPEP);

                //byte to string
                string mess = Encoding.ASCII.GetString(data);
                string printmess = RemoteIPEP.ToString() + ": " + data;
                lstMes.Items.Add(printmess);
            }
          
        }
        private void Vd1_Server_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread threadUDPServer = new Thread(new ThreadStart(serverThread));
            threadUDPServer.Start();
            threadUDPServer.IsBackground = true;
        }
    }
}
