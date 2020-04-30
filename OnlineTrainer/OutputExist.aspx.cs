using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTrainer
{
    public partial class OutputExist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bmiLabel.Text = Request.Cookies["BMI"].Value;
            push.Text = Request.Cookies["push0"].Value + "\n" + Request.Cookies["push1"].Value + " | " + Request.Cookies["push2"].Value + " | " + Request.Cookies["push3"].Value + " | " + Request.Cookies["push4"].Value + " | " + Request.Cookies["push5"].Value + " | " + Request.Cookies["push6"].Value + " | " + Request.Cookies["push7"].Value;
            pull.Text = Request.Cookies["pull0"].Value + " | " + Request.Cookies["pull1"].Value + " | " + Request.Cookies["pull2"].Value + " | " + Request.Cookies["pull3"].Value + " | " + Request.Cookies["pull4"].Value + " | " + Request.Cookies["pull5"].Value + " | " + Request.Cookies["pull6"].Value + " | " + Request.Cookies["pull7"].Value;
            leg.Text = Request.Cookies["leg0"].Value + " | " + Request.Cookies["leg1"].Value + " | " + Request.Cookies["leg2"].Value + " | " + Request.Cookies["leg3"].Value + " | " + Request.Cookies["leg4"].Value + " | " + Request.Cookies["leg5"].Value + " | " + Request.Cookies["leg6"].Value + " | " + Request.Cookies["leg7"].Value;
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Response.Cookies["push0"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push1"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push2"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push3"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push4"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push5"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push6"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["push7"].Expires = DateTime.Now.AddDays(-1);

            Response.Cookies["pull0"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull1"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull2"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull3"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull4"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull5"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull6"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["pull7"].Expires = DateTime.Now.AddDays(-1);

            Response.Cookies["leg0"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg1"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg2"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg3"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg4"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg6"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["leg"].Expires = DateTime.Now.AddDays(-1);

            Response.Cookies["BMI"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["Height"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["Weight"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["Sex"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("Home.aspx");
        }
    }
}