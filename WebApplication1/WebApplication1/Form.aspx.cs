using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Form : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
			string username = txtusername.Text;
			string email = txtemail.Text;
			string password = txtpassword.Text;
			Response.Redirect("Output.aspx?un=" + username + "&em=" + email + "&ps=" + password);
        }
    }
}