using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoLooping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            byte bteCount = 0;

            while (bteCount < 20)
            {
                bteCount++;
                lblWhile.Text += bteCount.ToString() + " ";
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            byte bteCount = 0;

            do
            {
                bteCount++;
                lblDo.Text += bteCount.ToString() + " ";
            } while (bteCount < 20);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {

            for (byte bteCount = 1; bteCount <= 250; bteCount++)
            {
                lblFor.Text += bteCount.ToString() + " ";
            }
        }

        private void btnBlueControls_Click(object sender, EventArgs e)
        {
            //btnWhile.BackColor = Color.Blue;
            foreach (Control control in this.Controls)
            {
                if (!(control is Label))
                {
                    control.BackColor = Color.Blue;
                }
                
            }

        }

        private void btnRedControls_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Red;
                }
            }
        }
    }
}
