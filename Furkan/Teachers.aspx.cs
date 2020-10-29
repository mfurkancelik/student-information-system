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
    public partial class Teachers1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

         
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into Marks(Sid,Midterm,Final,Cid,Status)values (@StudentNumber,@Midterm,@Final,@CourseNumber,@Status)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@StudentNumber", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Midterm", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Final", TextBox3.Text);
            cmd.Parameters.AddWithValue("@CourseNumber", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Status", TextBox1.Text);


            cmd.ExecuteNonQuery();

            Response.Write("Marks registeration Successfully!!!thank you");
       


            conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex);

            }
        }
    }
}