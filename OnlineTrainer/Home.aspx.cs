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
            Exercises exercises = new Exercises();

            exercises.create();
        }

        //Mitchell Bishop Push Test
        //Conner Ferguson push Test
        //Jacob Bodayka Push Test
        //Zachary Hardin Push Test
    }

    public class Exercises
    {
        string name;
        string muscle;
        string category;
        float weight;

        public void create(string name, string muscle, string category)
        {
            this.name = name;
            this.muscle = muscle;
            this.category = category;
        }
    }

}
