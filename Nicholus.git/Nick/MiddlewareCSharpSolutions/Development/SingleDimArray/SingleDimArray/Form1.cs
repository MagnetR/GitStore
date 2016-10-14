using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleDimArray
{
    public partial class Form1 : Form
    {
        private string[] strMonthNames = new string[12];
        public Form1()
        {
            InitializeComponent();
        }

        private void nudMonthNumber_ValueChanged(object sender, EventArgs e)
        {
            byte bteMonthNumber;           
            bteMonthNumber = Convert.ToByte(nudMonthNumber.Value);
           lblMonthName.Text = strMonthNames[bteMonthNumber -1];
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strMonthNames[0] = "January";
            strMonthNames[1] = "February";
            strMonthNames[2] = "March";
            strMonthNames[3] = "April";
            strMonthNames[4] = "May";
            strMonthNames[5] = "June";
            strMonthNames[6] = "July";
            strMonthNames[7] = "August";
            strMonthNames[8] = "September";
            strMonthNames[9] = "October";
            strMonthNames[10] = "November";
            strMonthNames[11] = "December";
            nudMonthNumber.Value = 1;
        }

        private void btnAllMonth_Click(object sender, EventArgs e)
        {
            lstAllMonth.Items.Clear();

            foreach (string month in strMonthNames)
            {
                lstAllMonth.Items.Add(month);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(strMonthNames);
            lstSortedMonths.Items.Clear();

            foreach (string month in strMonthNames)
            {
                lstSortedMonths.Items.Add(month);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstHuntingSeason.Items.Clear();

            foreach (string month in strMonthNames)
            {
                if (!month.Contains("r"))
                {
                    lstHuntingSeason.Items.Add(month);
                    lstHuntingSeason.BackColor = Color.Green;
                }
                
            }
        }
    }
}
