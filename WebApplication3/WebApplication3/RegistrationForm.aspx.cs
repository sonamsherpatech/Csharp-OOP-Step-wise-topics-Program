using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class RegistrationForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string result = "";
            result += "Name= " + txtName.Text;
            result += "\nPassword= " + txtPassword.Text;
            result += "\nReTypePassword= " + txtRePassword.Text;
            result += "\nAge= " + txtAge.Text;

            lblResult.Text = result;
        }

        protected void cvPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string password = txtPassword.Text;
            if(password.Length > 8)
            {
                args.IsValid = true;
            }else
            {
                args.IsValid = false;
            }
        }
    }
}