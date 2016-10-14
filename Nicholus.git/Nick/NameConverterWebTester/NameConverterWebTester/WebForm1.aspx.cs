using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using NameConvertor;

namespace NameConverterWebTester
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReverse_Click(object sender, EventArgs e)
        {
            NameConvertor.NameConvertor myConvertor = new NameConvertor.NameConvertor();
            lblOutput.Text = myConvertor.ReverseName(txtFirstName.Text);
        }
    }
}