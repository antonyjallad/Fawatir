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
    public partial class Infos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmailID"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString()))
            {
                conn.Open();
                string sql1 = "SELECT * FROM ServicesProvider WHERE email = @email";

                using (SqlCommand comm = new SqlCommand(sql1, conn))
                {
                    comm.Parameters.AddWithValue("@email", Session["email"].ToString());
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblFn.Text = reader.GetString(1);
                            lblLn.Text = reader.GetString(2);
                            lblMn.Text = reader.GetString(3);
                            lblEmail.Text = reader.GetString(7);
                            lblPn.Text = reader.GetString(5);
                            lblType.Text = reader.GetString(4);
                        }
                    }
                }
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["EmailID"] != null)
            {
                Session["EmailID"] = null;
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}