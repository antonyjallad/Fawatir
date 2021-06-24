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
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            Label11.Text = " ";

            HyperLink3.NavigateUrl = "ProfilePage.aspx?provider_id=" + Session["ProviderID"];
            HyperLink2.NavigateUrl = "NewService.aspx?provider_id=" + Session["ProviderID"];
            HyperLink1.NavigateUrl = "Infos.aspx?provider_id=" + Session["ProviderID"];
            HyperLink4.NavigateUrl = "NewJob.aspx?provider_id=" + Session["ProviderID"];
            HyperLink5.NavigateUrl = "RequestedServices.aspx?provider_id=" + Session["ProviderID"];
            HyperLink6.NavigateUrl = "users-registered?provider_id=" + Session["ProviderID"];
            HyperLink7.NavigateUrl = "bill.aspx?provider_id=" + Session["ProviderID"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["EmailID"] != null)
            {
                Session["EmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }

    protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != Session["CurrentPassword"].ToString())
            {
                Label11.Text="Current Password is not Correct!";
            }
            else if (TextBox2.Text == string.Empty || TextBox1.Text == string.Empty)
            {
                Label11.Text="Please Fill all the required field!";
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                    {

                        conn.Open();
                        String sql1 = "update ServicesProvider set password=@p where id = @id";
                        string password = TextBox2.Text.ToString();
                        using (SqlCommand com = new SqlCommand(sql1, conn))
                        {
                            com.Parameters.AddWithValue("@p", password);
                            com.Parameters.AddWithValue("@id", Session["ProviderID"]);
                            com.ExecuteNonQuery();
                            Response.Redirect("ProfilePage.aspx?provider_id=" + Session["ProviderID"]);
                        }
                    }
                }
                catch (SqlException)
                {
                    Label11.Text="Error occured, Please Try Again ";
                }
            }
        }
    }
}
            