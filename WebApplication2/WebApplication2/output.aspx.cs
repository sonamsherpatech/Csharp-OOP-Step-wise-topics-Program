using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
	public partial class output : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string rollNo = Request.QueryString["r"];
			string name = Request.QueryString["n"];
			string address = Request.QueryString["a"];
			string dob = Request.QueryString["d"];

			TxtRoll.Text = rollNo;
			TxtName.Text = name;
			TxtAddress.Text = address;
			TxtDOB.Text = dob;
		}
	}
}