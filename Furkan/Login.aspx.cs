using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furkan
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Students.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeachersLogin.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Label3.Text;
        }
    }
}