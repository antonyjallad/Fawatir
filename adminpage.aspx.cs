using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class adminpage : System.Web.UI.Page
    {
        string html;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {
                    conn.Open();
                    string sql2 = "Select count(1) from bills where month=@m ";
                    int count = 0;
                    using (SqlCommand comm = new SqlCommand(sql2, conn))
                    {
                        comm.Parameters.AddWithValue("@m", DateTime.Today.Month);
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                count = sdr.GetInt32(0);
                            }
                            if (count == 0)
                            {
                                Label1.Text = "There are no payed bills at the moment";
                            }
                            else
                            {
                                Label1.Text = " ";
                                html += "<table border=\"1\" id=\"services_table\"><tr><td width=15%>Invoice No:</td><td width=20%>Paid By </td><td width=15%>Month</td><td width=20%>Provider</td><td width=15%>Total</td></tr>";
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
        public string getWhileLoopData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {

                    conn.Open();

                    string sql = "select * from bills Inner Join Users on usere = email Inner Join ServicesProvider on p_id = Id where month=@m ";

                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        comm.Parameters.AddWithValue("@m", DateTime.Today.Month);

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                html += "<tr><td>No. " + sdr.GetInt32(0) + "</td>";
                                html += "<td>" + sdr.GetString(11) + " " + sdr.GetString(12) + " " + sdr.GetString(13) + "</td>";
                                html += "<td>" + DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(6)) + "</td>";

                                html += "<td>" + sdr.GetString(18) + " " + sdr.GetString(20) + " " + sdr.GetString(19) + "</td>";


                                html += "<td>" + sdr.GetInt32(9)+ " LBP</td>";
                                
                                
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
            html += "</table>";
            return html;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Session["admin"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}