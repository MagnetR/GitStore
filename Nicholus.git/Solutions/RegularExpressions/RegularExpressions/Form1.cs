using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (regex.IsMatch(txtExpression.Text))
            {
                errorProvider1.SetError(txtExpression, String.Empty);
            }
            else
            {
                errorProvider1.SetError(txtExpression, "Only numbers may be entered here");
            }
        }
    }
}
