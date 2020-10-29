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
    public partial class TeachersLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
            string insertQuery = "Select * from Teachers where Tid='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Teachers.aspx");

            }
            else
            {
                Response.Write("Teacher Number or password is incorrect");
            }
        }
    }
}