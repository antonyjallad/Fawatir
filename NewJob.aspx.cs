using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class NewJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            string sql = "SELECT * FROM ServicesProvider WHERE email = @email";
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection sqlCnx = new SqlConnection(connectionString);
            sqlCnx.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
            sqlCommand.Parameters.AddWithValue("@email", Session["email"].ToString());
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Label1.Text = sdr.GetString(1);
                Label2.Text = sdr.GetString(3);
                Label3.Text = sdr.GetString(2);
                Label5.Text = sdr.GetString(7);
                Label6.Text = sdr.GetString(5);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into jobs(title,sector,field,schedule,exp,shift,range,location,department,description,pfn,pln,pmn,ppn,pe,email)values(@t,@s,@f,@sch,@e,@sh,@r,@l,@d,@de,@pfn,@pln,@pmn,@ppn,@pe,@email)";
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection sqlCnx = new SqlConnection(connectionString);
            sqlCnx.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
            sqlCommand.Parameters.AddWithValue("@t", TextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@s", TextBox2.Text);
            sqlCommand.Parameters.AddWithValue("@f", TextBox3.Text);
            sqlCommand.Parameters.AddWithValue("@sch", TextBox4.Text);
            sqlCommand.Parameters.AddWithValue("@e", TextBox5.Text);
            sqlCommand.Parameters.AddWithValue("@sh", TextBox6.Text);
            sqlCommand.Parameters.AddWithValue("@r", TextBox7.Text);
            sqlCommand.Parameters.AddWithValue("@l", TextBox8.Text);
            sqlCommand.Parameters.AddWithValue("@d", TextBox9.Text);
            sqlCommand.Parameters.AddWithValue("@de", TextBox10.Text);
            sqlCommand.Parameters.AddWithValue("@email", TextBox11.Text);
            sqlCommand.Parameters.AddWithValue("@pfn", Label1.Text);
            sqlCommand.Parameters.AddWithValue("@pln", Label3.Text);
            sqlCommand.Parameters.AddWithValue("@pmn", Label2.Text);
            sqlCommand.Parameters.AddWithValue("@ppn", Label5.Text);
            sqlCommand.Parameters.AddWithValue("@pe", Label6.Text);
            sqlCommand.ExecuteNonQuery();


            Response.Redirect("ProfilePage.aspx");
        }
    }
}