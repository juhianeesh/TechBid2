﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechBid
{
	public partial class Contact : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Session.Remove("id");
			Session.Remove("username");
			Response.Redirect("index.aspx");
		}
	}
}