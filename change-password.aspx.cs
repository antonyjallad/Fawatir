using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserEmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            Label11.Text = " ";
            HyperLink2.NavigateUrl = "AvailableServices.aspx?UserID=" + Session["UserID"];
            HyperLink1.NavigateUrl = "UserProfilePage.aspx?UserID=" + Session["UserID"];
            Hyperlink4.NavigateUrl = "UserHomePage.aspx?UserID=" + Session["UserID"];
            Hyperlink3.NavigateUrl = "registeredservices.aspx?UserID=" + Session["UserID"];
            Hyperlink5.NavigateUrl = "jobs.aspx?UserID=" + Session["UserID"];
            Hyperlink6.NavigateUrl = "bills.aspx?UserID=" + Session["UserID"];
            Hyperlink7.NavigateUrl = "report.aspx?UserID=" + Session["UserID"];
            Hyperlink8.NavigateUrl = "latepayments.aspx?UserID=" + Session["UserID"];
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["UserEmailID"] != null)
            {
                Session["UserEmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox2.Text == string.Empty || TextBox1.Text == string.Empty)
            {
                Label11.Text = "Please Fill all the required field!";
            }
            else if (TextBox1.Text != Session["currentpassword"].ToString())
            {
                Label11.Text = "Current Password is incorrect!";
            }
            else
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {

                    conn.Open();
                    String sql1 = "update Users set password=@p where u_Id = @id";
                    string password = TextBox2.Text.ToString();
                    using (SqlCommand com = new SqlCommand(sql1, conn))
                    {
                        com.Parameters.AddWithValue("@p", password);
                        com.Parameters.AddWithValue("@id", Session["UserID"]);
                        com.ExecuteNonQuery();
                        Response.Redirect("UserProfilePage.aspx?UserID=" + Session["UserID"]);
                    }
                }
            }
        }
    }
}

