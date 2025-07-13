using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Output : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string username = Request.QueryString["un"];
			string email = Request.QueryString["em"];
			string password = Request.QueryString["ps"];

			txtUsername.Text = username;
			txtEmail.Text = email;
			txtPassword.Text = password;
		}
	}
}