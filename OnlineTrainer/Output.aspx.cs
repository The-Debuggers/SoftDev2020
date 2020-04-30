using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTrainer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void accountButton_Click(object sender, EventArgs e)
        {
            
            string s = "INSER INTO Table VALUES('" + username.Text+ "','" + password1.Text + "','" + Request.Cookies["Height"].Value + "','" + Request.Cookies["Weight"].Value + "','" + Request.Cookies["Sex"].Value + "')";
            SqlCommand cmd = new SqlCommand(s);
        }
    }
}