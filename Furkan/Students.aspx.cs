using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furkan
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
            string insertQuery = "Select * from Students where Sid='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Marks.aspx?Id="+TextBox1.Text+"");

            }
            else
            {
                Response.Write("School Number or password is incorrect");
            }

        }
    }
}