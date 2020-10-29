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
    public partial class Marks1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int veri = Convert.ToInt32(Request.QueryString["Id"]);
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
          
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(connectionString);
          
            comm = new SqlCommand($"Select * from Marks where Sid='{veri}'", conn);
            try
            {
             
                conn.Open();
                reader = comm.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
              
                reader.Close();
            }
         
            catch
            {
                Response.Write("Bir hata oluştu");
            }
           
            finally
            {
                conn.Close();
            }
        }
    }
}