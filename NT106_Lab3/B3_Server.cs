using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace NT106_Lab3
{
    public partial class frmB3_Server : Form
    {
        public frmB3_Server()
        {
            InitializeComponent();
        }

        private void UnsafeThread()
        {
            IPEndPoint IPEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            rtbMess.AppendText("Server is running on" +
                IPEP.Address.ToString() + ":" +
                IPEP.Port.ToString() + "\n");

            int bytesreceive = 0;
            byte[] BytesRecevei = new byte[1];

            Socket ClientSocket;
            Socket Listener = new Socket
                (AddressFamily.InterNetwork,
                SocketType.Stream, 
                ProtocolType.Tcp
                );

            Listener.Bind(IPEP);
            Listener.Listen(1);
            ClientSocket = Listener.Accept();

            rtbMess.AppendText("New client connected.\n");

            while(ClientSocket.Connected)
            {
                string text="";
                do
                {
                    bytesreceive = ClientSocket.Receive(BytesRecevei);
                    text += Encoding.ASCII.GetString(BytesRecevei);
                } while (text[text.Length - 1] != '\n');
               // Listener.Close();
            }
        }    
        
        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(UnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }
    }
}
