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
using System.Text.RegularExpressions;

namespace HRSystem
{
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }
        public void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tmrColour_Tick(object sender, EventArgs e)
        {
            Random bckColour = new Random();
            this.BackColor = Color.FromArgb(bckColour.Next(1), bckColour.Next(10), bckColour.Next(255));
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection hrConnection = new SqlConnection(@"Data Source = NMR1404A\NMR1404; Initial Catalog = HRSystem; Integrated Security = True");
            SqlCommand hrCommand;
            hrConnection.Open();

            hrCommand = new SqlCommand("INSERT into UserInfo (ID_number,FirstName,SecondName,LastName,Gender,PhoneNumber,Nationality,ResidentialAddress,EmailAddress) values('" + txtIDNumber.Text + "','" + txtFirstName.Text + "','" + txtSecondName.Text + "','" + txtLastName.Text + "','" + combotxtGender.Text + "','" + txtPhoneNumber.Text + "','" + txtNationality.Text + "','" + txtResidentialAddress.Text + "','" + txtEmailAddress.Text + "' )", hrConnection);
            hrCommand.ExecuteNonQuery();
            //hrCommand.Parameters.Add("@FirstName", txtFirstName.Text);
            hrConnection.Close();
            ClearData();
            MessageBox.Show("Info Submitted succesfully");
        }

        public void ClearData()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIDNumber.Text = null;
            txtNationality.Clear();
            txtPhoneNumber.Clear();
            txtResidentialAddress.Clear();
            txtSecondName.Clear();
            //combotxtGender.Items.Remove(combotxtGender.SelectedItem);
            
                combotxtGender.SelectedItem = null;
            txtEmailAddress.Clear();
            errorProvider1.Clear();
            txtPhoneNumber.BackColor = Color.White;
            txtIDNumber.BackColor = Color.White;
            txtEmailAddress.BackColor = Color.White;
        }
        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
                 @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
                 @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";

            Match emailMatch = Regex.Match(txtEmailAddress.Text.Trim(), emailPattern, RegexOptions.IgnoreCase);

            if ((!String.IsNullOrEmpty(txtEmailAddress.Text)))
            {
                if (!(emailMatch.Success))
                {
                    txtEmailAddress.Text = string.Empty;
                    errorProvider1.SetError(txtEmailAddress, "Please enter a valid email address");
                    txtEmailAddress.BackColor = Color.Yellow;
                }
                else if (emailMatch.Success)
                {
                    errorProvider1.Clear();
                    txtEmailAddress.BackColor = Color.White;
                }
            }
        }
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            string phonePattern = @"(^0[1678][01234689][0-9]{7})";
            Match phoneMatch = Regex.Match(txtPhoneNumber.Text.Trim(), phonePattern, RegexOptions.IgnoreCase);

            if (!String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (!(phoneMatch.Success) || txtPhoneNumber.Text.Length > 10)
                {
                    txtPhoneNumber.Text = string.Empty;
                    errorProvider1.SetError(txtPhoneNumber, "Please enter a valid phone number");
                    txtPhoneNumber.BackColor = Color.Yellow;
                }
                else if (phoneMatch.Success)
                {
                    errorProvider1.Clear();
                    txtPhoneNumber.BackColor = Color.White;
                }
            }
        }
        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            string IDPattern = @"^([0-9]){2}(0[1-9]|1[0-2])(0[0-9]|[1-2][0-9]|3[0-1])([0-9]){4}([0-1])([0-9]){2}?$";
            Match IDMatch = Regex.Match(txtIDNumber.Text.Trim(), IDPattern, RegexOptions.IgnoreCase);

            if ((!String.IsNullOrEmpty(txtIDNumber.Text)))
            {
                if (!(IDMatch.Success))
                {
                    txtIDNumber.Text = string.Empty;
                    errorProvider1.SetError(txtIDNumber, "Please enter a valid ID number");
                    txtIDNumber.BackColor = Color.Yellow;
                }
                else if (IDMatch.Success)
                {
                    errorProvider1.Clear();
                    txtIDNumber.BackColor = Color.White;
                }
            }

            if (!String.IsNullOrEmpty(txtIDNumber.Text) && !(txtIDNumber.Text.Length < 13))
            {
                int idGnd = Convert.ToInt32(txtIDNumber.Text.Substring(6, 1));
                int idN = Convert.ToInt32(txtIDNumber.Text.Substring(10, 1));

                if (idGnd > 4)
                {
                    combotxtGender.SelectedItem = combotxtGender.Items[0];
                }
                else
                {
                    combotxtGender.SelectedItem = combotxtGender.Items[1];
                }

                if (idN == 0)
                {
                    txtNationality.SelectedText = "South African";
                }
                else
                {
                    txtNationality.SelectedText = "Other";
                }
            }
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e);
        }

        public void DigitsOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TextOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnly(e);
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnly(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnly(e);
        }

        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnly(e);
        }

        private void txtSearch_Click(object sender, EventArgs a)
        {
            SqlConnection hrConnection = new SqlConnection(@"Data Source = NMR1404A\NMR1404; Initial Catalog = HRSystem; Integrated Security = True");
            SqlCommand hrCommand;
            SqlDataReader read;
            hrConnection.Open();
            hrCommand = new SqlCommand("SELECT * FROM UserInfo WHERE ID_number = '" + txtIDNumber.Text + "'", hrConnection);
            hrCommand.ExecuteNonQuery();
            hrCommand.CommandType = CommandType.Text;
            read = hrCommand.ExecuteReader();

            while (read.Read())
            {
                txtFirstName.Text = (string)((IDataReader)read)[1];
                txtSecondName.Text = (string)((IDataReader)read)[2];
                txtLastName.Text = (string)((IDataReader)read)[3];
                combotxtGender.SelectedItem = (string)((IDataReader)read)[4];
                txtPhoneNumber.Text = (string)((IDataReader)read)[5];
                txtNationality.Text = (string)((IDataReader)read)[6];
                txtResidentialAddress.Text = (string)((IDataReader)read)[7];
                txtEmailAddress.Text = (string)((IDataReader)read)[8];

            }
        }

      
    }
}