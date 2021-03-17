using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["EmailID"] != null)
            {
                Session["EmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}