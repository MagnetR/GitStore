using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButtons_Click(object sender, EventArgs e)
        {
           if(lblScreen.Text.Length < 15)
           {
               //lblScreen.Text += (sender as Button).Text;
               lblScreen.Text += ((Button)sender).Text;
           }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lblScreen.Text.Length > 0)
            {
                lblScreen.Text = lblScreen.Text.Remove(lblScreen.Text.Length - 1, 1);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblScreen_Click(object sender, EventArgs e)
        {

        }

    }
}
