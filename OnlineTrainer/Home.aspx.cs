using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTrainer
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void buttonLose_Click(object sender, EventArgs e)
        {
            HttpCookie weightCookie = new HttpCookie("Goal", "Lose");
            Response.Redirect("Inputs.aspx");
        }

        protected void buttonGain_Click(object sender, EventArgs e)
        {
            HttpCookie weightCookie = new HttpCookie("Goal", "Gain");
            Response.Redirect("Inputs.aspx");
        }
        protected void buttonBoth_Click(object sender, EventArgs e)
        {
            HttpCookie weightCookie = new HttpCookie("Goal", "Both");
            Response.Redirect("Inputs.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }

    
}
