using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnTorque = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            cnTorque.ConnectionString = @"Data Source=NMR1404A\NMR1404;Initial Catalog=Torque;Integrated Security=True;Pooling=False";
            SqlCommand cmGetCities = new SqlCommand();
            cmGetCities.Connection = cnTorque;
            cmGetCities.CommandText = "SELECT DISTINCT city FROM Student";

            SqlDataReader drCities;
            cnTorque.Open();
            drCities = cmGetCities.ExecuteReader();
            while (drCities.Read())
            {
                cboCities.Items.Add(drCities.GetString(0));
            }
            drCities.Close();
            cnTorque.Close();

            cboCities.Items.Insert(0, "[All]");
            cboCities.SelectedIndex = 0;
            
        }

        private void cboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSelectedCity = cboCities.Text;

            SqlCommand cmGetStudents = new SqlCommand();
            cmGetStudents.Connection = cnTorque;


            if (cboCities.SelectedIndex == 0)
            {
                cmGetStudents.CommandText = "SELECT * FROM Student";
            }
            else
            {

                cmGetStudents.CommandText = "SELECT * FROM Student WHERE city = @city";
                SqlParameter cityParam = new SqlParameter();
                cityParam.ParameterName = "@city";
                cityParam.Direction = ParameterDirection.Input;
                cityParam.Value = strSelectedCity;
                cmGetStudents.Parameters.Add(cityParam);
            }

            SqlDataAdapter daStudents = new SqlDataAdapter();
            daStudents.SelectCommand = cmGetStudents;

            DataSet dsStudents = new DataSet();

            daStudents.Fill(dsStudents);
            dgvStudents.DataSource = dsStudents.Tables[0];
        }
    }
}
