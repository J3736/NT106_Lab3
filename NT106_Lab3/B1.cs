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
    public partial class frmB1 : Form
    {
        public frmB1()
        {
            InitializeComponent();
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            frmB1_Client frm = new frmB1_Client();
            if (Application.OpenForms.OfType<frmB1_Client>().Any())
                MessageBox.Show("Already Opened.");
            
            else
                frm.Show();
        }

        private void btnSv_Click(object sender, EventArgs e)
        {
            frmB1_Server frm = new frmB1_Server();
            if (Application.OpenForms.OfType<frmB1_Server>().Any())
                MessageBox.Show("Already Opened.");
            else
                frm.Show();
        }
    }
}
