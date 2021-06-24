using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawatir
{
    public partial class bills_details1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }

            HyperLink3.NavigateUrl = "ProfilePage.aspx?provider_id=" + Session["ProviderID"];
            HyperLink2.NavigateUrl = "NewService.aspx?provider_id=" + Session["ProviderID"];
            HyperLink1.NavigateUrl = "Infos.aspx?provider_id=" + Session["ProviderID"];
            HyperLink4.NavigateUrl = "NewJob.aspx?provider_id=" + Session["ProviderID"];
            HyperLink5.NavigateUrl = "RequestedServices.aspx?provider_id=" + Session["ProviderID"];
            HyperLink6.NavigateUrl = "users-registered?provider_id=" + Session["ProviderID"];
            HyperLink7.NavigateUrl = "bill.aspx?provider_id" + Session["ProviderID"];
        }
        public string getDiv()
        {
            string html = "<table border=\"1\" id=\"services_tables\"><tr>";
            if (Request["water_invoice_id"] != null)
            {
                html += "<td>Water Bill</td></tr>";
                int id = Convert.ToInt32(Request["water_invoice_id"].ToString());
                string sql = "select * from bills Inner Join waterservices on s_id=w_Id Inner Join Users on usere=email where b_Id = @id and type=@type and p_id=@u";
                String cnxString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(cnxString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@u", Session["ProviderID"]);
                sqlCommand.Parameters.AddWithValue("@type", "Water");
                sqlCommand.ExecuteNonQuery();
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                if (sdr.Read())
                {
                    Session["payedname"] = sdr.GetString(20) + " " + sdr.GetString(21) + " " + sdr.GetString(22);

                    Session["payeddate"] = DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7));
                    Session["payedtype"] = sdr.GetString(3);
                    html += "<tr><td>Provider: " + sdr.GetString(13) + " " + sdr.GetString(15) + " " + sdr.GetString(14) + "</td></tr>";
                    html += "<tr><td>Phone Number: " + sdr.GetString(16) + "</td></tr>";
                    html += "<tr><td>Month:" + DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7)) + "</td><tr>";
                    html += "<tr><td>Payed By: " + sdr.GetString(20) + " " + sdr.GetString(21) + " " + sdr.GetString(22) + "</td></tr>";
                    html += "<tr><td>Payment Invoice NO. :" + sdr.GetInt32(0) + "</td></tr>";
                    html += "<tr><td>Liters: " + sdr.GetInt32(11) + "</td></tr>";
                    html += "<tr><td>Total:  " + sdr.GetInt32(12) + "</td></tr>";
                    html += "<tr><td>Pay Date: " + sdr.GetInt32(4) + "/" + sdr.GetInt32(6) + "/" + DateTime.Today.Year + "</td></tr>";
                    html += "<tr><td>Total Payment: " + sdr.GetInt32(12) + " LBP</td></tr>";
                }
                html += "</table>";
            }
            else if (Request["internet_invoice_id"] != null)
            {
                int id = Convert.ToInt32(Request["internet_invoice_id"].ToString());
                html += "<td>Internet Bill</td></tr>";
                string sql = "select * from bills Inner Join InternetServices on s_id=i_Id Inner Join Users on usere=email where b_Id = @id and type=@type and p_id=@u";
                String cnxString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(cnxString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@u", Session["ProviderID"]);
                sqlCommand.Parameters.AddWithValue("@type", "Internet");
                sqlCommand.ExecuteNonQuery();
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                if (sdr.Read())
                {
                    Session["payedname"]= sdr.GetString(20) + " " + sdr.GetString(21) + " " + sdr.GetString(22);

                    Session["payeddate"] = DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7));
                    Session["payedtype"] = sdr.GetString(3);
                    html += "<tr><td>Provider: " + sdr.GetString(13) + " " + sdr.GetString(15) + " " + sdr.GetString(14) + "</td></tr>";
                    html += "<tr><td>Phone Number: " + sdr.GetString(16) + "</td></tr>";
                    html += "<tr><td>Month:" + DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7)) + "</td><tr>";
                    html += "<tr><td>Payed By: " + sdr.GetString(20) + " " + sdr.GetString(21) + " " + sdr.GetString(22) + "</td></tr>";
                    html += "<tr><td>Payment Invoice NO. :" + sdr.GetInt32(0) + "</td></tr>";
                    html += "<tr><td>Quota Limit: " + sdr.GetInt32(11) + "</td></tr>";
                    html += "<tr><td>Total:  " + sdr.GetInt32(12) + "</td></tr>";
                    html += "<tr><td>Pay Date: " + sdr.GetInt32(4) + "/" + sdr.GetInt32(6) + "/" + DateTime.Today.Year + "</td></tr>";
                    html += "<tr><td>Total Payment: " + sdr.GetInt32(12) + " LBP</td></tr>";
                }
                sqlCnx.Close();
                html += "</table>";
            }
            else if (Request["local_invoice_id"] != null)
            {

                int id = Convert.ToInt32(Request["local_invoice_id"].ToString());
                html += "<td>Local Bill</td></tr>";
                string sql = "select * from bills Inner Join LocalServices on s_id=l_Id Inner Join Users on usere=email where b_Id = @id and type=@type and p_id=@u";
                String cnxString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx = new SqlConnection(cnxString);
                sqlCnx.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlCnx);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@u", Session["ProviderID"]);
                sqlCommand.Parameters.AddWithValue("@type", "Local");
                sqlCommand.ExecuteNonQuery();
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                if (sdr.Read())
                {

                    Session["payeddate"] = DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7));
                    Session["payedtype"] = sdr.GetString(3);
                    Session["payedname"] = sdr.GetString(17) + " " + sdr.GetString(18) + " " + sdr.GetString(19);
                    html += "<tr><td>Provider: " + sdr.GetString(13) + "</td></tr>";
                    html += "<tr><td>Phone Number: " + sdr.GetString(14) + "</td></tr>";
                    html += "<tr><td>Month:" + DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr.GetInt32(7)) + "</td><tr>";
                    html += "<tr><td>Payed By: " + sdr.GetString(17) + " " + sdr.GetString(18) + " " + sdr.GetString(19) + "</td></tr>";
                    html += "<tr><td>Payment Invoice NO. :" + sdr.GetInt32(0) + "</td></tr>";
                    html += "<tr><td>Service Name: " + sdr.GetString(11) + "</td></tr>";
                    html += "<tr><td>Total:  " + sdr.GetInt32(12) + "</td></tr>";
                    html += "<tr><td>Pay Date: " + sdr.GetInt32(4) + "/" + sdr.GetInt32(6) + "/" + DateTime.Today.Year + "</td></tr>";
                    html += "<tr><td>Total Payment: " + sdr.GetInt32(12) + " LBP</td></tr>";
                }

                sqlCnx.Close();
                html += "</table>";
            }
            if (Request["electricity_invoice_id"] != null)
            {
                int id = Convert.ToInt32(Request["electricity_invoice_id"].ToString());
                html += "<td>Electricity Bill</td></tr>";
                string sql1 = "select * from bills Inner Join electricityservices on s_id=e_Id Inner Join Users on usere=email where b_Id = @id and type=@type and p_id=@u";
                String cnxString1 = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlCnx1 = new SqlConnection(cnxString1);
                sqlCnx1.Open();
                SqlCommand sqlCommand1 = new SqlCommand(sql1, sqlCnx1);
                sqlCommand1.Parameters.AddWithValue("@id", id);
                sqlCommand1.Parameters.AddWithValue("@u", Session["ProviderID"]);
                sqlCommand1.Parameters.AddWithValue("@type", "Electricity");

                sqlCommand1.ExecuteNonQuery();
                SqlDataReader sdr1 = sqlCommand1.ExecuteReader();
                if (sdr1.Read())
                {
                    Session["payeddate"] = DateTimeFormatInfo.CurrentInfo.GetMonthName(sdr1.GetInt32(7));
                    Session["payedtype"] = sdr1.GetString(3);
                    Session["payedname"] = sdr1.GetString(21) + " " + sdr1.GetString(22) + " " + sdr1.GetString(23);
                    html += "<tr><td>Provider: " + sdr1.GetString(14) + " " + sdr1.GetString(16) + " " + sdr1.GetString(15) + "</td></tr>";
                    html += "<tr><td>Phone Number: " + sdr1.GetString(17) + "</td></tr>";
                    html += "<tr><td>Month:" + DateTimeFormatInfo.CurrentInfo.GetMonthName( sdr1.GetInt32(7)) + "</td><tr>";
                    html += "<tr><td>Payed By: " + sdr1.GetString(21) + " " + sdr1.GetString(22) + " " + sdr1.GetString(23) + "</td></tr>";
                    html += "<tr><td>Payment Invoice NO. :" + sdr1.GetInt32(0) + "</td></tr>";
                    html += "<tr><td>Consumption: " + sdr1.GetInt32(8) + " KW</td></tr>";
                    html += "<tr><td>Amps: " + sdr1.GetInt32(11) + "</td></tr>";
                    html += "<tr><td>Unit Price: " + sdr1.GetInt32(13) + "</td></tr>";
                    html += "<tr><td>Maintenance: " + sdr1.GetInt32(12) + "</td></tr>";
                    html += "<tr><td>Pay Date: " + sdr1.GetInt32(4) + "/" + sdr1.GetInt32(6) + "/" + DateTime.Today.Year + "</td></tr>";
                    html += "<tr><td>Total Payment: " + sdr1.GetInt32(9) + " LBP</td></tr>";
                }
                sqlCnx1.Close();
                html += "</table>";
            }
            html += "</html>";
            Session["html"] = html;
            return html;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter tw = new StringWriter(sb);
            HtmlTextWriter hw = new HtmlTextWriter(tw);
            Page.RenderControl(hw);
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/msword";
            string strFileName = Session["payedname"] + " Invoice/month: " + Session["payeddate"] + ".doc";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "inline;filename=" + strFileName);
            HttpContext.Current.Response.Write(Session["html"].ToString());
            HttpContext.Current.Response.End();
            HttpContext.Current.Response.Flush();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["EmailID"] != null)
            {
                Session["ProviderID"] = null;
                Session["EmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}