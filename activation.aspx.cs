using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class activation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["code"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            Label1.Text = "<html><h1>Activation Code</h1><h2>Hello " + Session["actfn"] + " " + Session["actmn"] + " " + Session["actln"] + "</h2><p> A code has been sent to this email:" + Session["actemail"] + ".<br> If you did not receive a code, please go back and change it or make sure it is correct</p>";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)
            {
                Label11.Text = "Enter your code";
            }
            else
            {
                string x = TextBox1.Text;
                int i;
                if (int.TryParse(x, out i))
                {
                    if (i == Convert.ToInt32(Session["code"]))
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                            con.Open();
                            string sql = "INSERT INTO Users (fn, mn, ln, pn, email, password) VALUES (@fn, @mn, @ln, @pn, @email, @pass)";

                            SqlCommand comm = new SqlCommand(sql, con);
                            comm.Parameters.AddWithValue("@fn", Session["actfn"]);
                            comm.Parameters.AddWithValue("@mn", Session["actmn"]);
                            comm.Parameters.AddWithValue("@ln", Session["actln"]);
                            comm.Parameters.AddWithValue("@pn", Session["actpn"]);
                            comm.Parameters.AddWithValue("@email", Session["actemail"]);
                            comm.Parameters.AddWithValue("@pass", Session["actpass"]);
                            comm.ExecuteNonQuery();
                            con.Close();
                            Response.Redirect("user-login-form.aspx");
                            con.Close();
                        }
                        catch (SqlException)
                        {
                            Label11.Text="Error occured, Please Try Again " ;
                        }
                    }
                    else
                    {
                        Label11.Text = "Your code is Incorrect";
                    }
                }
                else
                    Label11.Text = "Please Enter a number";
            }
        }
    }
}
    
