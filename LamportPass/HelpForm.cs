using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LamportPass
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            rtbHelp.Text = Properties.Resources.Workflow;
            btnWorkflow.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamport_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = Properties.Resources.About_Lamport;
            btnLamport.Enabled = false;
            btnWorkflow.Enabled = true;
            btnAbout.Enabled = true;
        }

        private void btnWorkflow_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = Properties.Resources.Workflow;
            btnLamport.Enabled = true;
            btnWorkflow.Enabled = false;
            btnAbout.Enabled = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = Properties.Resources.About;
            btnLamport.Enabled = true;
            btnWorkflow.Enabled = true;
            btnAbout.Enabled = false;
        }
    }
}
