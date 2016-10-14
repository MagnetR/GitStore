using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            Random numbers = new Random();
            //numbers.ToString();
            for (int num = 1; num < 50; num++)
            {
                txtResults1.Text = numbers.Next(1,49).ToString();
                txtResults2.Text = numbers.Next(1, 49).ToString();
                txtResults3.Text = numbers.Next(1, 49).ToString();
                txtResults4.Text = numbers.Next(1, 49).ToString();
                txtResults5.Text = numbers.Next(1, 49).ToString();
                txtResults6.Text = numbers.Next(1, 49).ToString();
            }
        }
    }
}
