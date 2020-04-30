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
            bmiLabel.Text = Request.Cookies["BMI"].Value;
            push.Text = Request.Cookies["push0"].Value + " | " + Request.Cookies["push1"].Value + " | " + Request.Cookies["push2"].Value + " | " + Request.Cookies["push3"].Value + " | " + Request.Cookies["push4"].Value + " | " + Request.Cookies["push5"].Value + " | " + Request.Cookies["push6"].Value + " | " + Request.Cookies["push7"].Value;
            pull.Text = Request.Cookies["pull0"].Value + " | " + Request.Cookies["pull1"].Value + " | " + Request.Cookies["pull2"].Value + " | " + Request.Cookies["pull3"].Value + " | " + Request.Cookies["pull4"].Value + " | " + Request.Cookies["pull5"].Value + " | " + Request.Cookies["pull6"].Value + " | " + Request.Cookies["pull7"].Value;
            leg.Text = Request.Cookies["leg0"].Value + " | " + Request.Cookies["leg1"].Value + " | " + Request.Cookies["leg2"].Value + " | " + Request.Cookies["leg3"].Value + " | " + Request.Cookies["leg4"].Value + " | " + Request.Cookies["leg5"].Value + " | " + Request.Cookies["leg6"].Value + " | " + Request.Cookies["leg7"].Value;
        }

        protected void accountButton_Click(object sender, EventArgs e)
        {
            string s = "INSERT INTO [Table] VALUES('" + username.Text + "','" + password1.Text + "','" + Request.Cookies["Height"].Value + "','" + Request.Cookies["Weight"].Value + "','" + Request.Cookies["Sex"].Value + "')";
            string conS = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\zacha\\Dropbox\\College\\Year 3 (2019-2020)\\Semester 2\\Computer Science 478\\Project\\SoftDev2020\\OnlineTrainer\\App_Data\\Database1.mdf\"; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(conS))
            {
                SqlCommand command = new SqlCommand(s, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            Response.Redirect("OutputExist.aspx");
            
        }
    }
}