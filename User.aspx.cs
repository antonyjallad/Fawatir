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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (TextBox3.Text == string.Empty || TextBox4.Text == string.Empty || TextBox5.Text == string.Empty || TextBox6.Text == string.Empty || TextBox7.Text == string.Empty || TextBox8.Text == string.Empty || TextBox9.Text == string.Empty)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('All Fields Should be Filled!')", true);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                    conn.Open();
                    string sql2 = "Select count(1) from Users where email=@email";
                    SqlCommand com = new SqlCommand(sql2, conn);
                    com.Parameters.AddWithValue("@email", TextBox7.Text);
                    com.ExecuteNonQuery();
                    SqlDataReader sdr = com.ExecuteReader();
                    int count = 0;
                    while (sdr.Read())
                    {
                        count = sdr.GetInt32(0);
                    }
                    if (count == 0)
                    {
                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                        con.Open();
                        string sql = "INSERT INTO Users (fn, mn, ln, pn, email, password) VALUES (@fn, @mn, @ln, @pn, @email, @pass)";

                        SqlCommand comm = new SqlCommand(sql, con);
                        comm.Parameters.AddWithValue("@fn", TextBox3.Text);
                        comm.Parameters.AddWithValue("@mn", TextBox4.Text);
                        comm.Parameters.AddWithValue("@ln", TextBox5.Text);
                        comm.Parameters.AddWithValue("@pn", TextBox6.Text);
                        comm.Parameters.AddWithValue("@email", TextBox7.Text);
                        comm.Parameters.AddWithValue("@pass", TextBox8.Text);
                        comm.ExecuteNonQuery();
                        con.Close();
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('Account Created, Now Please Login')", true);
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('Email already used')", true);
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    Response.Write("Error occured: " + ex.Message);
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty || TextBox2.Text == string.Empty)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('All Fields Should be Filled!')", true);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {

                    conn.Open();

                    string sql1 = "SELECT * FROM Users WHERE Email = @email AND Password = @pass";

                    using (SqlCommand comm = new SqlCommand(sql1, conn))
                    {
                        comm.Parameters.AddWithValue("@email", TextBox2.Text);
                        comm.Parameters.AddWithValue("@pass", TextBox1.Text);

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session["UserEmail"] = TextBox2.Text;
                                Session["UserEmailID"] = TextBox2.Text;

                                /* Session["UserID"] = reader["RegisterID"];
                                 Session["UserEmailID"] = txtEmail.Text;
                                 Session["Email"] = txtEmail.Text;
                                 Session["name"] = reader["Name"];
                                 Session["pp"] = reader["ProfilePic"];
                                 string MyID = Session["UserID"].ToString();
                                 Session["CurrentProfileId"] = Session["UserID"];*/
                                Response.Redirect("UserHomePage.aspx");
                            }
                            else
                            {
                                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "alert('Incorrect Email or Password!.')", true);
                            }
                        }
                    }

                    conn.Close();
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Error occured: " + ex.Message);
            }
        }
    }
}