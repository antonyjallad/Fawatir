using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class consumption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserEmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            Label1.Text = Request["payment_id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)
            {
                Label1.Text = "Please Enter your consumption";
            }
            else
            {
                string x = TextBox1.Text;
                int i;

                if (int.TryParse(x, out i))
                {
                    Session["consumption"] = TextBox1.Text;
                    Session["duepayment"] = Request["electricity_payment_id"].ToString();
                    Response.Redirect("payment.aspx?UserID=" + Session["UserID"]+"//electricity_payment_id ="+Session["duepayment"]);
                }
                else
                {
                    Label1.Text = "Please Enter a number only";
                }
            }
        }
    }
}