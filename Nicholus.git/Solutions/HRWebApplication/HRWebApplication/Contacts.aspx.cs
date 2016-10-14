using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRWebApplication
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx", true);
        }

        protected void btnVision_Click(object sender, EventArgs e)
        {
            Server.Transfer("Vision.aspx", true);
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Server.Transfer("History.aspx", true);
        }

        protected void btnValues_Click(object sender, EventArgs e)
        {
            Server.Transfer("Value.aspx", true);
        }

        protected void btnContacts_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserInput.aspx", true);
        }
    }
}