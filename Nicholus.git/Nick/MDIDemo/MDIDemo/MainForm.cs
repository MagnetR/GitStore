using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class MainForm : Form
    {
        int docNumber = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChild doc = new MDIChild();
            doc.MdiParent = this;
            docNumber++;
            doc.Text = "Document" + docNumber.ToString();
            doc.Show();
            lblDoc.Text = ActiveMdiChild.Text;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newDocumentToolStripMenuItem.PerformClick();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
