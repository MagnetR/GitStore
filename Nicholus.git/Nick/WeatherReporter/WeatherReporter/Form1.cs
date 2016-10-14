using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColour.SelectedIndex = 0;
            cboMode.SelectedIndex = 0;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            string strColour, strMode;

            strColour = cboColour.Text;
            strMode = cboMode.Text;

            tmrBlue.Enabled = false;
            tmrRed.Enabled = false;

            if(strMode + strColour == "SteadyBlue")
            {
                lblWeather.Text = "Steady Blue - Clear View";
                lblWeather.BackColor = Color.White;
                lblWeather.ForeColor = Color.Blue;
               
            }
            else if (strMode + strColour == "FlashingBlue")
            {
                lblWeather.Text = "Flashing Blue - Clouds Due";
                lblWeather.BackColor = Color.Blue;
                lblWeather.ForeColor = Color.White;
                tmrBlue.Enabled = true;
            }
            else if(strMode + strColour == "SteadyRed")
            {
                lblWeather.Text = "Steady Red - Rain Ahead";
                lblWeather.BackColor = Color.White;
                lblWeather.ForeColor = Color.Red;
            }
            else if (strMode + strColour == "FlashingRed")
            {
                lblWeather.Text = "Flashing Red - Snow Instead";
                lblWeather.BackColor = Color.Red;
                lblWeather.ForeColor = Color.White;
                tmrRed.Enabled = true;
            }
            else 
            {
                lblWeather.Text = "Broken Light";
                lblWeather.BackColor = Color.Yellow;
                lblWeather.ForeColor = Color.Red;
            }
        }

        private void btnPredicSWITCH_Click(object sender, EventArgs e)
        {
            string strMode, strColour;

            strMode = cboMode.Text;
            strColour = cboColour.Text;

            tmrBlue.Enabled = false;
            tmrRed.Enabled = false;

            switch(strMode + strColour)
            {
                case "SteadyBlue":
                    lblWeather.Text = "Steady Blue - Clear View";
                    lblWeather.BackColor = Color.White;
                    lblWeather.ForeColor = Color.Blue;
                    break;
                case "FlashingBlue":
                    lblWeather.Text = "Flashing Blue - Clouds Due";
                    lblWeather.BackColor = Color.Blue;
                    lblWeather.ForeColor = Color.White;
                    tmrBlue.Enabled = true;
                    break;
                case "SteadyRed":
                    lblWeather.Text = "Steady Red - Rain Ahead";
                    lblWeather.BackColor = Color.White;
                    lblWeather.ForeColor = Color.Red;
                    break;
                case "FlashingRed":
                    lblWeather.Text = "Flashing Red - Snow Instead";
                    lblWeather.BackColor = Color.Red;
                    lblWeather.ForeColor = Color.White;
                    tmrRed.Enabled = true;
                    break;
                default: 
                    lblWeather.Text = "Broken Light";
                    lblWeather.BackColor = Color.Yellow;
                    lblWeather.ForeColor = Color.Red;
                    break;
            }
        }

        private void tmrBlue_Tick(object sender, EventArgs e)
        {
            if (lblWeather.BackColor == Color.Blue)
            {
                lblWeather.BackColor = Color.White;
                lblWeather.ForeColor = Color.Blue;
            }
            else
            {
                lblWeather.BackColor = Color.Blue;
                lblWeather.ForeColor = Color.White;
            }
        }

        private void tmrRed_Tick(object sender, EventArgs e)
        {
            if (lblWeather.BackColor == Color.Red)
            {
                lblWeather.BackColor = Color.White;
                lblWeather.ForeColor = Color.Red;
            }
            else
            {
                lblWeather.BackColor = Color.Red;
                lblWeather.ForeColor = Color.White;
            }
        }
    }
}
