using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    public  class UserDetails
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }

        SqlConnection hrConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=HRSystem;Integrated Security=True");
        SqlCommand hrCommand;

        private SqlDataReader RetrieveUserDetails(string IdNumber)
        {
            SqlDataReader reader;
            hrConnection.Open();
            hrCommand = new SqlCommand("SELECT * FROM UserInfo WHERE ID_number=@IdNumber", hrConnection);
            hrCommand.Parameters.AddWithValue("@IdNumber", IdNumber);
            hrCommand.ExecuteNonQuery();
            hrCommand.CommandType = CommandType.Text;
            reader = hrCommand.ExecuteReader();
            return reader;
        }

        public bool StoreUser(UserDetails User)
        {
            try
            {
                hrConnection.Open();
                hrCommand = new SqlCommand("INSERT into UserInfo (ID_number,FirstName,LastName) values(@IdNumber,@FirstName,@LastName)", hrConnection); //,@Gender,@ContactNo
                hrCommand.Parameters.Add("@IdNumber", User.IdNumber);
                hrCommand.Parameters.Add("@FirstName", User.FirstName);
                hrCommand.Parameters.Add("@LastName", User.LastName);
                //hrCommand.Parameters.Add("@Gender", User.LastName);
                //hrCommand.Parameters.Add("@ContactNo", User.LastName);
                hrCommand.ExecuteNonQuery();
                hrConnection.Close();
                return true;
            }
            catch 
            {
                hrConnection.Close();
                return false;
            }
        }

    }
}
