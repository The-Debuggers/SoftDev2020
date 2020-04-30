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
            int weightLBS = int.Parse(weight.Text);
            int heightFTParsed = int.Parse(heightFT.Text);
            int heightINParsed = int.Parse(heightIN.Text);
            int heightTotal = heightFTParsed * 12 + heightINParsed;                      //fyi... this variable is JUST IN INCHES
            HttpCookie heightCookie = new HttpCookie("Height", heightTotal.ToString());
            HttpCookie weightCookie = new HttpCookie("Weight", weight.Text);
            HttpCookie sexCookie = new HttpCookie("Sex", sex.SelectedValue);

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
            Session["BMI"] = user.generate_BMI(heightTotal, weightLBS);
            List<Exercises> pushday = user.generate_pushday(chest_list, shoulder_list, tricep_list);
            Session["push1"] = pushday[1];

            Session["PullDay"] = user.generate_pullday(back_list, bicep_list);
            Session["LegDay"] = user.generate_legday(quadricep_list, hamstring_list, gluteal_list, calf_list);

            Response.Redirect("Output.aspx");
        }

        protected void verifyNumber(object source, ServerValidateEventArgs args)
        {
            args.IsValid = int.TryParse(heightFT.Text, out int num);
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
}