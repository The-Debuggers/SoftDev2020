using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTrainer
{
    public partial class Inputs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void submitButton_Click(object sender, EventArgs e)
        {
            int heightFTParsed = int.Parse(heightFT.Text);
            int heightINParsed = int.Parse(heightIN.Text);
            int heightTotal = heightFTParsed * 12 + heightINParsed;                      //fyi... this variable is JUST IN INCHES
            HttpCookie heightCookie = new HttpCookie("Height", heightTotal.ToString());
            HttpCookie weightCookie = new HttpCookie("Weight", weight.Text);
            HttpCookie sexCookie = new HttpCookie("Sex", sex.SelectedValue);
            Response.Redirect("Output.aspx");
        }

        protected void verifyNumber(object source, ServerValidateEventArgs args)
        {
            args.IsValid = int.TryParse(heightFT.Text, out int num);
        }
    }
}