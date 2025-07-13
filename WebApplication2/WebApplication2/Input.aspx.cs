using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
	public partial class Input : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
			string roll = TxtRollNo.Text;
			string name = TxtName.Text;
			string address = TxtAddress.Text;
			string dob = TxtDOB.Text;

			Response.Redirect("output.aspx?r=" + roll + "&n=" + name + "&a=" + address + "&d=" + dob);
        }
    }
}