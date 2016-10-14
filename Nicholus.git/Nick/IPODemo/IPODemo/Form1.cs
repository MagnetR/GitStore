using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfor_Click(object sender, EventArgs e)
        {
            //Input
            string strTittle, strFirstName, strSurName;
            DateTime dteDateOfBirth;
            bool blnIsMale;

            strTittle = cboTittle.Text;
            strFirstName = txtFirstName.Text;
            strSurName = txtSurname.Text;
            dteDateOfBirth = dtpDateOfBirth.Value;
            blnIsMale = chkIsMale.Checked;

            //Processing
            string strFullName = strTittle +" " + strFirstName +" "+ strSurName;


            //Output
            lstInfor.Items.Clear();
            lstInfor.Items.Add("INFORMATION FOR " + strFullName.ToUpper());
            lstInfor.Items.Add("");

            lstInfor.Items.Add("Date of Birth: "
                + dteDateOfBirth.ToLongDateString());
            lstInfor.Items.Add("Is male? " + blnIsMale);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTittle.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void tmrRandoColour_Tick(object sender, EventArgs e)
        {
            Random rndColour = new Random();

            //this.BackColor = Color.Green;
          this.BackColor = Color.FromArgb(rndColour.Next(255), rndColour.Next(255), rndColour.Next(255));

        }

    }
}
