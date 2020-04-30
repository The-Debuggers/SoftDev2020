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
            push.Text = Request.Cookies["push"].Value;
            pull.Text = Request.Cookies["pull"].Value;
            leg.Text = Request.Cookies["leg"].Value;
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
            
        }
    }
}