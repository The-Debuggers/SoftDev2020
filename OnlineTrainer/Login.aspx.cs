using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Nest;

namespace OnlineTrainer
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            User[] currentUser = null;
            string s = "SELECT * FROM [Table] WHERE username = '" + username.Text + "';";
            string conS = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\zacha\\Dropbox\\College\\Year 3 (2019-2020)\\Semester 2\\Computer Science 478\\Project\\SoftDev2020\\OnlineTrainer\\App_Data\\Database1.mdf\"; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(conS))
            {
                SqlCommand command = new SqlCommand(s, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                var list = new List<User>();
                while (reader.Read())
                {
                    list.Add(new User { name = reader.GetString(0), pass = reader.GetString(1), height = reader.GetInt32(2), weight = reader.GetInt32(3), sex = reader.GetString(4) });
                }
                currentUser = list.ToArray();
                reader.Close();
            }
            if (password.Text != currentUser[0].pass)
            {
                errorMsg.Visible = true;
            }
            {
                //Push day exercises
                List<Exercises> chest_list = new List<Exercises>
            {
                //Pectorals
                new Exercises {name = "Flat Barbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Incline Barbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Decline Barbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Flat Dumbbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Incline Dumbbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Decline Dumbbell Chest Press", muscle = "Chest", category = "Multi-Joint"},
                new Exercises {name = "Flat Dumbbell Chest Fly", muscle = "Chest", category = "Single-Joint"},
                new Exercises {name = "Incline Dumbbell Chest Fly", muscle = "Chest", category = "Single-Joint"},
                new Exercises {name = "Decline Dumbbell Chest Fly", muscle = "Chest", category = "Single-Joint"},
                new Exercises {name = "Standard Cable Chest Fly", muscle = "Chest", category = "Single-Joint"},
                new Exercises {name = "Incline Cable Chest Fly", muscle = "Chest", category = "Single-Joint"},
                new Exercises {name = "Decline Cable Chest Fly", muscle = "Chest", category = "Single-Joint"},
            };

                List<Exercises> shoulder_list = new List<Exercises>
            {                
                //Deltoids
                new Exercises {name = "Seated Barbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Standing Barbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Seated Dumbbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Standing Dumbbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Side Lateral Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Cable Side Lateral Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Dumbbell Front Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Cable Front Raise", muscle = "Shoulder", category = "Single-Joint"},
            };

                List<Exercises> tricep_list = new List<Exercises>
            {
                //Triceps
                new Exercises {name = "Close-Grip Barbell Chest Press", muscle = "Tricep", category = "Multi-Joint"},
                new Exercises {name = "Medicine Ball Pushup", muscle = "Tricep", category = "Multi-Joint"},
                new Exercises {name = "Diamond Pushup", muscle = "Tricep", category = "Multi-Joint"},
                new Exercises {name = "Dumbell Kickback", muscle = "Tricep", category = "Single-Joint"},
                new Exercises {name = "Cable Kickback", muscle = "Tricep", category = "Single-Joint"},
                new Exercises {name = "Dumbbell Skullcrusher", muscle = "Tricep", category = "Single-Joint"},
                new Exercises {name = "EZ-Bar Skullcrusher", muscle = "Tricep", category = "Single-Joint"},
                new Exercises {name = "Cable Tricep Pushdown", muscle = "Tricep", category = "Single-Joint"}
            };

                //Pull day exercises
                List<Exercises> back_list = new List<Exercises>
            {
                //Back
                new Exercises {name = "Pull-ups", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Lat Pulldown", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Seated Cable Row", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Bent-Over Barbell Row", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Bent-Over Dumbbell Row", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "T-Bar Row", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Facepulls", muscle = "Back", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Reverse Fly", muscle = "Back", category = "Single-Joint"},
                new Exercises {name = "Cable Reverse Fly", muscle = "Back", category = "Single-Joint"},
            };

                List<Exercises> bicep_list = new List<Exercises>
            {
                //Biceps
                new Exercises {name = "Chin-ups", muscle = "Bicep", category = "Multi-Joint"},
                new Exercises {name = "Standing Dumbbell Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Seated Dumbbell Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Standing Dumbbell Hammer Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Seated Dumbbell Hammer Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Seated Incline Dumbbell Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Dumbbell Preacher Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "EZ-Bar Preacher Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Standing EZ-Bar Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Standing Barbell Curl", muscle = "Bicep", category = "Single-Joint"},
                new Exercises {name = "Standing Cable Curl", muscle = "Bicep", category = "Single-Joint"}
            };

                //Leg day exercises
                List<Exercises> quadricep_list = new List<Exercises>
            {
                //Quadricep
                new Exercises {name = "Barbell Back Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Goblet Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Bulgarian Split Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Lunge", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Leg Press", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Leg Extension", muscle = "Quadricep", category = "Single-Joint"},
            };

                List<Exercises> hamstring_list = new List<Exercises>
            {
                //Hamstring
                new Exercises {name = "Barbell Romanian Deadlift", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Romanian Deadlift", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Stability Ball Glute-Ham Raise", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Leg Curl", muscle = "Hamstring", category = "Single-Joint"},
            };

                List<Exercises> gluteal_list = new List<Exercises>
            {
                //Gluteal
                new Exercises {name = "Barbell Hip Thrust", muscle = "Gluteal", category = "Multi-Joint"},
                new Exercises {name = "Barbell Glute Bridge", muscle = "Gluteal", category = "Multi-Joint"},
            };

                List<Exercises> calf_list = new List<Exercises>
            {
                //Calf
                new Exercises {name = "Seated Calf Raise", muscle = "Calf", category = "Single-Joint"},
                new Exercises {name = "Smith Machine Calf Raise", muscle = "Calf", category = "Single-Joint"}
            };

                Exercises user = new Exercises();

                //creates BMI cookie
                double BMI = user.generate_BMI(currentUser[0].height, currentUser[0].weight);
                HttpCookie BMICookie = new HttpCookie("BMI", BMI.ToString());
                BMICookie.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(BMICookie);

                //Creates lists of exercises for output
                List<Exercises> pushday = user.generate_pushday(chest_list, shoulder_list, tricep_list);
                HttpCookie pday0 = new HttpCookie("push0", pushday[0].name.ToString());
                pday0.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday0);
                HttpCookie pday1 = new HttpCookie("push1", pushday[1].name.ToString());
                pday0.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday1);
                HttpCookie pday2 = new HttpCookie("push2", pushday[2].name.ToString());
                pday2.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday2);
                HttpCookie pday3 = new HttpCookie("push3", pushday[3].name.ToString());
                pday3.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday3);
                HttpCookie pday4 = new HttpCookie("push4", pushday[4].name.ToString());
                pday4.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday4);
                HttpCookie pday5 = new HttpCookie("push5", pushday[5].name.ToString());
                pday5.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday5);
                HttpCookie pday6 = new HttpCookie("push6", pushday[6].name.ToString());
                pday6.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday6);
                HttpCookie pday7 = new HttpCookie("push7", pushday[7].name.ToString());
                pday7.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(pday7);

                List<Exercises> pullday = user.generate_pullday(back_list, bicep_list);
                HttpCookie uday0 = new HttpCookie("pull0", pullday[0].name.ToString());
                uday0.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday0);
                HttpCookie uday1 = new HttpCookie("pull1", pullday[1].name.ToString());
                uday1.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday1);
                HttpCookie uday2 = new HttpCookie("pull2", pullday[2].name.ToString());
                uday2.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday2);
                HttpCookie uday3 = new HttpCookie("pull3", pullday[3].name.ToString());
                uday3.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday3);
                HttpCookie uday4 = new HttpCookie("pull4", pullday[4].name.ToString());
                uday4.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday4);
                HttpCookie uday5 = new HttpCookie("pull5", pullday[5].name.ToString());
                uday5.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday5);
                HttpCookie uday6 = new HttpCookie("pull6", pullday[6].name.ToString());
                uday6.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday6);
                HttpCookie uday7 = new HttpCookie("pull7", pullday[7].name.ToString());
                uday7.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(uday7);

                List<Exercises> legday = user.generate_legday(quadricep_list, hamstring_list, gluteal_list, calf_list);
                HttpCookie leg0 = new HttpCookie("leg0", legday[0].name.ToString());
                leg0.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg0);
                HttpCookie leg1 = new HttpCookie("leg1", legday[1].name.ToString());
                leg1.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg1);
                HttpCookie leg2 = new HttpCookie("leg2", legday[2].name.ToString());
                leg2.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg2);
                HttpCookie leg3 = new HttpCookie("leg3", legday[3].name.ToString());
                leg3.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg3);
                HttpCookie leg4 = new HttpCookie("leg4", legday[4].name.ToString());
                leg4.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg4);
                HttpCookie leg5 = new HttpCookie("leg5", legday[5].name.ToString());
                leg5.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg5);
                HttpCookie leg6 = new HttpCookie("leg6", legday[6].name.ToString());
                leg6.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg6);
                HttpCookie leg7 = new HttpCookie("leg7", legday[7].name.ToString());
                leg7.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(leg7);

                Response.Redirect("OutputExist.aspx");
            }
        }
    }

    public class Exercises
    {
        public string name;
        public string muscle;
        public string category;
        public int reps;
        public double weight;

        static Random rnd = new Random();

        public void create(string name, string muscle, string category)
        {
            this.name = name;
            this.muscle = muscle;
            this.category = category;
        }

        public double generate_BMI(int heighttotalIN, int weightLBS)
        {
            double heightM = heighttotalIN * 0.0254;
            double weightKG = weightLBS * 0.454;
            double BMI = weightKG / (heightM * heightM);

            return BMI;
        }

        public List<Exercises> generate_pushday(List<Exercises> chest_list, List<Exercises> shoulder_list, List<Exercises> tricep_list)
        {
            List<Exercises> pushday = new List<Exercises>();
            List<int> random_numbers1 = new List<int>();
            List<int> random_numbers2 = new List<int>();
            List<int> random_numbers3 = new List<int>();

            //adds chest exercises to pushday
            while (pushday.Count < 3)
            {
                int r = rnd.Next(chest_list.Count);
                if (random_numbers1.Contains(r) == false)
                {
                    pushday.Add(chest_list[r]);
                    random_numbers1.Add(r);
                }
            }

            //adds shoulder exercises to pushday
            while (pushday.Count < 6)
            {
                int r = rnd.Next(shoulder_list.Count);
                if (random_numbers2.Contains(r) == false)
                {
                    pushday.Add(shoulder_list[r]);
                    random_numbers2.Add(r);
                }
            }

            //adds tricep exercises to pushday
            while (pushday.Count < 8)
            {
                int r = rnd.Next(tricep_list.Count);
                if (random_numbers3.Contains(r) == false)
                {
                    pushday.Add(tricep_list[r]);
                    random_numbers3.Add(r);
                }
            }

            return pushday;
        }

        public List<Exercises> generate_pullday(List<Exercises> back_list, List<Exercises> bicep_list)
        {
            List<Exercises> pullday = new List<Exercises>();
            List<int> random_numbers1 = new List<int>();
            List<int> random_numbers2 = new List<int>();

            //adds back exercises to pullday
            while (pullday.Count < 4)
            {
                int r = rnd.Next(back_list.Count);
                if (random_numbers1.Contains(r) == false)
                {
                    pullday.Add(back_list[r]);
                    random_numbers1.Add(r);
                }
            }

            //adds bicep exercises to pullday
            while (pullday.Count < 8)
            {
                int r = rnd.Next(bicep_list.Count);
                if (random_numbers2.Contains(r) == false)
                {
                    pullday.Add(bicep_list[r]);
                    random_numbers2.Add(r);
                }
            }

            return pullday;
        }

        public List<Exercises> generate_legday(List<Exercises> quadricep_list, List<Exercises> hamstring_list, List<Exercises> gluteal_list, List<Exercises> calf_list)
        {
            List<Exercises> legday = new List<Exercises>();
            List<int> random_numbers1 = new List<int>();
            List<int> random_numbers2 = new List<int>();

            //adds quadricep exercises to legday
            while (legday.Count < 3)
            {
                int r = rnd.Next(quadricep_list.Count);
                if (random_numbers1.Contains(r) == false)
                {
                    legday.Add(quadricep_list[r]);
                    random_numbers1.Add(r);
                }
            }

            //adds hamstring exercises to legday
            while (legday.Count < 6)
            {
                int r = rnd.Next(hamstring_list.Count);
                if (random_numbers2.Contains(r) == false)
                {
                    legday.Add(hamstring_list[r]);
                    random_numbers2.Add(r);
                }
            }

            //adds guteal exercises to legday
            while (legday.Count < 7)
            {
                int r = rnd.Next(gluteal_list.Count);
                legday.Add(gluteal_list[r]);
            }

            //adds calf exercise to legday
            while (legday.Count < 8)
            {
                int r = rnd.Next(calf_list.Count);
                legday.Add(calf_list[r]);
            }

            return legday;
        }
    }
}

public class User
{
    public string name { get; set; }
    public string pass { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
    public string sex { get; set; }

}
