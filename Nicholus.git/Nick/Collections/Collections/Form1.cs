using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue<string> qPlanets = new Queue<string>();

            qPlanets.Enqueue("Mercury");
            qPlanets.Enqueue("Venus");
            qPlanets.Enqueue("Earth");
            qPlanets.Enqueue("Uranus");
            qPlanets.Enqueue("Jupiter");
            qPlanets.Enqueue("Saturn");
            qPlanets.Enqueue("Mars");
            qPlanets.Enqueue("Neptune");

            lblPlanets.Text = "";

            foreach (string strPlanet in qPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }
            lblPlanets.Text += "----------------\n";

            qPlanets.Dequeue();
            qPlanets.Dequeue();
            qPlanets.Dequeue();
            qPlanets.Dequeue();
            foreach (string strPlanet in qPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack<string> stkPlanets = new Stack<string>();


            stkPlanets.Push("Mercury");
            stkPlanets.Push("Venus");
            stkPlanets.Push("Earth");
            stkPlanets.Push("Uranus");
            stkPlanets.Push("Jupiter");
            stkPlanets.Push("Saturn");
            stkPlanets.Push("Mars");
            stkPlanets.Push("Neptune");

            lblPlanets.Text = "";

            foreach (string strPlanet in stkPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }
            lblPlanets.Text += "----------------\n";

            stkPlanets.Pop();

            foreach (string strPlanet in stkPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }
        }

        private void btnGeneralPur_Click(object sender, EventArgs e)
        {
            List<string> lstPlanets = new List<string>();

            lstPlanets.Add("Mercury");
            lstPlanets.Add("Venus");
            lstPlanets.Add("Earth");
            lstPlanets.Add("Uranus");
            lstPlanets.Add("Jupiter");
            lstPlanets.Add("Saturn");
            lstPlanets.Add("Mars");
            lstPlanets.Add("Neptune");

            foreach (string strPlanet in lstPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }
            lblPlanets.Text += "----------------\n";

            lstPlanets.Remove("Earth");
            lstPlanets.RemoveAt(4);


            foreach (string strPlanet in lstPlanets)
            {
                lblPlanets.Text += strPlanet + "\n";
            }

        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            SortedList<string, string> sltPlanets = new SortedList<string, string>();

            sltPlanets.Add("ME", "Mercury");
            sltPlanets.Add("V", "Venus");
            sltPlanets.Add("E", "Earth");
            sltPlanets.Add("U", "Uranus");
            sltPlanets.Add("J", "Jupiter");
            sltPlanets.Add("S", "Saturn");
            sltPlanets.Add("M", "Mars");
            sltPlanets.Add("N", "Neptune");

            lblPlanets.Text = "";

            foreach (string intPlanetNumber in sltPlanets.Keys)
            {
                lblPlanets.Text += intPlanetNumber.ToString() + "\n";
            }

            lblPlanets.Text += "----------------\n";

            foreach (string vluPlanetNumber in sltPlanets.Values)
            {
                lblPlanets.Text += vluPlanetNumber + "\n";
            }

           

        }
    }
}
