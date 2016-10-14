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

namespace Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 10, y = 3, z = x / y;

                SqlConnection cnAdventureWorks = new SqlConnection();
                //cnAdventureWorks.ConnectionString = "Dummy";
                SqlCommand cmGetProducts = new SqlCommand();
                cmGetProducts.Connection = cnAdventureWorks;
                cmGetProducts.CommandText = "SELECT * FROM Production.Product";
                SqlDataAdapter daProducts = new SqlDataAdapter();
                daProducts.SelectCommand = cmGetProducts;
                DataSet dsProducts = new DataSet();
                daProducts.Fill(dsProducts);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Division by Zero not possible");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Database not accessable");
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Connection to Database failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
