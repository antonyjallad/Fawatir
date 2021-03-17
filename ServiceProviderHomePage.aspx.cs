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
    public partial class ServiceProviderHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {
                    sqlCnx.Open();

                    string sql1 = "SELECT * FROM ServicesProvider WHERE Email = @email AND Password = @password";

                    using (SqlCommand comm = new SqlCommand(sql1, sqlCnx))
                    {
                        comm.Parameters.AddWithValue("@email", TextBox1.Text);
                        comm.Parameters.AddWithValue("@password", TextBox2.Text);

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session["Email"] = TextBox1.Text;
                                Session["EmailID"] = TextBox1.Text;
                                Session["Type"] = reader.GetString(4);
                                /*Session["UserID"] = reader["RegisterID"];
                                Session["name"] = reader["Name"];
                                string MyID = Session["UserID"].ToString();
                                Session["CurrentProfileId"] = Session["UserID"];*/
                                Response.Redirect("ProfilePage.aspx");
                            }
                            else
                            {
                                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('Incorrect Email or Password!.')", true);
                            }
                        }
                    }

                    sqlCnx.Close();
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Error occured: " + ex.Message);
            }
        }
    }
}
