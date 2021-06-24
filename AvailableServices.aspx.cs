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
    public partial class AvailableServices : System.Web.UI.Page
    {
        string html;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserEmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }

            HyperLink2.NavigateUrl = "AvailableServices.aspx?UserID=" + Session["UserID"];
            HyperLink1.NavigateUrl = "UserProfilePage.aspx?UserID=" + Session["UserID"];
            Hyperlink4.NavigateUrl = "UserHomePage.aspx?UserID=" + Session["UserID"];
            Hyperlink3.NavigateUrl = "registeredservices.aspx?UserID=" + Session["UserID"];
            Hyperlink5.NavigateUrl = "jobs.aspx?UserID=" + Session["UserID"];
            Hyperlink6.NavigateUrl = "bills.aspx?UserID=" + Session["UserID"];
            Hyperlink7.NavigateUrl = "report.aspx?UserID=" + Session["UserID"];
            Hyperlink8.NavigateUrl = "latepayments.aspx?UserID=" + Session["UserID"];
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
                {

                    conn.Open();
                    string sql2 = "Select count(1) from allservices";
                    int count = 0;
                    using (SqlCommand comm = new SqlCommand(sql2, conn))
                    {
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                count = sdr.GetInt32(0);
                            }
                            if (count == 0)
                            {
                                Label1.Text = "There is no services at the moment";
                            }
                            else
                            {
                                Label1.Text = "";         
                                html = "<table border=\"1\" id=\"services_table\"><tr><td width=30%>Service Type</td><td width=30%>Provider Name</td><td width=15%></td></tr>";

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

                    string sql = "select * from electricityservices";

                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        Session["Electricity"] = "Electricity";
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                html += "<tr><td>Electricity</td>";
                                html += "<td>" + sdr.GetString(4) + " " + sdr.GetString(6) + " " + sdr.GetString(5) + "</td>";
                                html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details(" + sdr.GetInt32(0) + ")\">" + "</td>";
                            }
                        }
                    }
                    string sql1 = "select * from waterservices";
                    using (SqlCommand comm = new SqlCommand(sql1, conn))
                    {
                        Session["Water"] = "Water";

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                html += "<tr><td>Water</td>";
                                html += "<td>" + sdr.GetString(3) + " " + sdr.GetString(5) + " " + sdr.GetString(4) + "</td>";
                                html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details1(" + sdr.GetInt32(0) + ")\">" + "</td>";
                            }
                        }
                    }
                    string sql2 = "select * from InternetServices";
                    using (SqlCommand comm = new SqlCommand(sql2, conn))
                    {
                        Session["Internet"] = "Internet";

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                html += "<tr><td>Internet</td>";
                                html += "<td>" + sdr.GetString(3) + " " + sdr.GetString(5) + " " + sdr.GetString(4) + "</td>";
                                html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details2(" + sdr.GetInt32(0) + ")\">" + "</td>";

                            }
                        }
                    }
                    string sql3 = "select * from LocalServices";
                    using (SqlCommand comm = new SqlCommand(sql3, conn))
                    {
                        Session["Local"] = "Local";
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                html += "<tr><td>Local</td>";
                                html += "<td>" + sdr.GetString(3) + "</td>";
                                html += "<td style=\"width:6%\"><input type=\"button\" value=\"Details\" onclick=\"Details3(" + sdr.GetInt32(0) + ")\">" + "</td>";
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
            html += "</tr></table>";
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