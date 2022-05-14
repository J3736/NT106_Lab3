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
    public partial class frmB3_Client : Form
    {
        public frmB3_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            IPEndPoint IPEP = new IPEndPoint(
                IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient.Connect(IPEP);

            NetworkStream ns = tcpClient.GetStream();
            Byte[] data = Encoding.ASCII.GetBytes("Hello world \n");
            ns.Write(data,0,data.Length);
            Byte[] stop = Encoding.ASCII.GetBytes("Quit \n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }
    }
}
