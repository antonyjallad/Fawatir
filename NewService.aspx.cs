using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class NewService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            if (Session["Type"].ToString()=="Internet")
            {
                
                string sql = "SELECT * FROM ServicesProvider WHERE email = @email";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@email", Session["email"].ToString());
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    Label2.Text = sdr.GetString(1);
                    Label3.Text = sdr.GetString(3);
                    Label4.Text=sdr.GetString(2);
                    Label5.Text = sdr.GetString(7);
                    Label6.Text = sdr.GetString(5);
                }
             
                Label7.Text = "Quota Limit";
                Label8.Text = "Price";
            }
            else if (Session["Type"].ToString() == "Electricity")
            {

                string sql = "SELECT * FROM ServicesProvider WHERE email = @email";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@email", Session["email"].ToString());
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    Label2.Text = sdr.GetString(1);
                    Label3.Text = sdr.GetString(3);
                    Label4.Text = sdr.GetString(2);
                    Label5.Text = sdr.GetString(7);
                    Label6.Text = sdr.GetString(5);
                }

                Label7.Text = "AMP";
                Label8.Text = "Maintenance";
                Label9.Text = "Electricity Service";
                Label10.Text = "Unit Price";
                Label11.Text = "730";
            }
            if (Session["Type"].ToString() == "Water")
            {

                string sql = "SELECT * FROM ServicesProvider WHERE email = @email";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@email", Session["email"].ToString());
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    Label2.Text = sdr.GetString(1);
                    Label3.Text = sdr.GetString(3);
                    Label4.Text = sdr.GetString(2);
                    Label5.Text = sdr.GetString(7);
                    Label6.Text = sdr.GetString(5);
                }

                Label7.Text = "Litre";
                Label8.Text = "Price";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Type"].ToString() == "Internet")
            {
                int price = Convert.ToInt32(TextBox2.Text);
                int limit = Convert.ToInt32(TextBox1.Text);
                string sql = "insert into InternetServices(price,limit,pfn,pln,pmn,ppn,pe)values(@p,@l,@pfn,@pln,@pmn,@ppn,@pe)";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@p", price);
                sqlCommand.Parameters.AddWithValue("@l", limit);
                sqlCommand.Parameters.AddWithValue("@pfn", Label2.Text);
                sqlCommand.Parameters.AddWithValue("@pln", Label4.Text);
                sqlCommand.Parameters.AddWithValue("@pmn", Label3.Text);
                sqlCommand.Parameters.AddWithValue("@ppn", Label5.Text);
                sqlCommand.Parameters.AddWithValue("@pe", Label6.Text);
                sqlCommand.ExecuteNonQuery();

                Response.Redirect("ProfilePage.aspx");


            }
            else if (Session["Type"].ToString() == "Electricity")
            {
                int  price= Convert.ToInt32(Label11.Text);

                int main = Convert.ToInt32(TextBox2.Text);
                int amp = Convert.ToInt32(TextBox1.Text);
                string sql = "insert into electricityservices(amp,main,price,pfn,pln,pmn,ppn,pe)values(@a,@m,@p,@pfn,@pln,@pmn,@ppn,@pe)";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@a", amp);
                sqlCommand.Parameters.AddWithValue("@m", main);
                sqlCommand.Parameters.AddWithValue("@p", price);
                sqlCommand.Parameters.AddWithValue("@pfn", Label2.Text);
                sqlCommand.Parameters.AddWithValue("@pln", Label4.Text);
                sqlCommand.Parameters.AddWithValue("@pmn", Label3.Text);
                sqlCommand.Parameters.AddWithValue("@ppn", Label5.Text);
                sqlCommand.Parameters.AddWithValue("@pe", Label6.Text);
                sqlCommand.ExecuteNonQuery();

                Response.Redirect("ProfilePage.aspx");

            }
            else if (Session["Type"].ToString() == "Water")
            {
                int price = Convert.ToInt32(TextBox2.Text);
                int litre = Convert.ToInt32(TextBox1.Text);
                string sql = "insert into waterservices(litre,price,pfn,pln,pmn,ppn,pe)values(@l,@p,@pfn,@pln,@pmn,@ppn,@pe)";
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(connectionString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@l", litre);
                sqlCommand.Parameters.AddWithValue("@p", price);
                sqlCommand.Parameters.AddWithValue("@pfn", Label2.Text);
                sqlCommand.Parameters.AddWithValue("@pln", Label4.Text);
                sqlCommand.Parameters.AddWithValue("@pmn", Label3.Text);
                sqlCommand.Parameters.AddWithValue("@ppn", Label5.Text);
                sqlCommand.Parameters.AddWithValue("@pe", Label6.Text);
                sqlCommand.ExecuteNonQuery();

                Response.Redirect("ProfilePage.aspx");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["EmailID"] != null)
            {
                Session["EmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}