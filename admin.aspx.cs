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
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == null || TextBox2.Text == null)
            {
                Label11.Text = "All Fields Should be Filled";
            }
            else
            {
                try
                {
                    using (SqlConnection sqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                    {
                        sqlCnx.Open();

                        string sql1 = "SELECT * FROM admin WHERE username = @email AND Password = @password";

                        using (SqlCommand comm = new SqlCommand(sql1, sqlCnx))
                        {
                            comm.Parameters.AddWithValue("@email", TextBox1.Text);
                            comm.Parameters.AddWithValue("@password", TextBox2.Text);

                            using (SqlDataReader reader = comm.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Session["admin"] = reader.GetString(1);
                                    Response.Redirect("adminpage.aspx");
                                }
                                else
                                {
                                    Label11.Text = "Incorrect Username or Password";
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
}