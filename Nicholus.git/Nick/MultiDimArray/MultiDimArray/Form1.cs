using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDimArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDistance_Click(object sender, EventArgs e)
        {
            byte bteFrom, bteTo;
            short[,] shtDistances = new short[4, 4];

            bteFrom = (byte)nudFrom.Value;
            bteTo = (byte)nudTo.Value;

            shtDistances[0, 0] = 0;
            shtDistances[0, 1] = 450;
            shtDistances[0, 2] = 560;
            shtDistances[0, 3] = 1600;
            shtDistances[1, 0] = 450;
            shtDistances[1, 1] = 0;
            shtDistances[1, 2] = 600;
            shtDistances[1, 3] = 1000;
            shtDistances[2, 0] = 560;
            shtDistances[2, 1] = 600;
            shtDistances[2, 2] = 0;
            shtDistances[2, 3] = 1200;
            shtDistances[3, 0] = 1600;
            shtDistances[3, 1] = 100;
            shtDistances[3, 2] = 1200;
            shtDistances[3, 3] = 0;


            lblOutPut.Text = shtDistances[bteFrom - 1, bteTo - 1].ToString() + " Kilometers";

        }
    }
}
