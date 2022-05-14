using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab3
{
    public partial class frmB3 : Form
    {
        public frmB3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            frmB3_Server frm = new frmB3_Server();
            if (Application.OpenForms.OfType<frmB3_Server>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmB3_Client frm = new frmB3_Client();
            if (Application.OpenForms.OfType<frmB3_Client>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }
    }
}
