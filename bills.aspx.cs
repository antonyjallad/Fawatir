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
    public partial class bills : System.Web.UI.Page
    {
        string html;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserEmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {
                    conn.Open();
                    string sql2 = "Select count(1) from bills where usere=@e";
                    int count = 0;
                    using (SqlCommand comm = new SqlCommand(sql2, conn))
                    {
                        comm.Parameters.AddWithValue("@e", Session["UserEmailID"]);
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
                                html += "<table border=\"1\" id=\"services_table\"><tr><td width=30%>Invoice No:</td><td width=30%>Type</td><td width=30%>Month</td><td width=15%></td></tr>";

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

                    string sql = "select * from bills where usere=@u";

                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        comm.Parameters.AddWithValue("@u", Session["UserEmailID"]);
                        comm.ExecuteNonQuery();
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                 html += "<tr><td>No. "+sdr.GetInt32(0)+"</td>";
                                 html += "<td>" + sdr.GetString(3) + "</td>";
                                html += "<td>" + DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7)) + "</td>";
                                if (sdr.GetString(3) == "Internet")
                                {
                                    html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details1(" + sdr.GetInt32(0) + ")\">" + "</td></tr>";
                                }
                                else if (sdr.GetString(3) == "Water")
                                {
                                    html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details2(" + sdr.GetInt32(0) + ")\">" + "</td></tr>";
                                }
                                else if(sdr.GetString(3)=="Electricity")
                                {
                                    html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details3(" + sdr.GetInt32(0) + ")\">" + "</td></tr>";
                                }
                                else if(sdr.GetString(3)=="Local")
                                {
                                    html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details4(" + sdr.GetInt32(0) + ")\">" + "</td></tr>";
                                }
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
            if (Session["UserEmailID"] != null)
            {
                Session["UserEmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}