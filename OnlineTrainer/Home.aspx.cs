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
            //Push day exercises
            List<Exercises> push_list = new List<Exercises>
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
                //Deltoids
                new Exercises {name = "Seated Barbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Standing Barbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Seated Dumbbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Standing Dumbbell Overhead Press", muscle = "Shoulder", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Side Lateral Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Cable Side Lateral Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Dumbbell Front Raise", muscle = "Shoulder", category = "Single-Joint"},
                new Exercises {name = "Cable Front Raise", muscle = "Shoulder", category = "Single-Joint"},
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
            List<Exercises> pull_list = new List<Exercises>
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
            List<Exercises> leg_list = new List<Exercises>
            {
                //Quadricep
                new Exercises {name = "Barbell Back Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Goblet Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Bulgarian Split Squat", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Lunge", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Leg Press", muscle = "Quadricep", category = "Multi-Joint"},
                new Exercises {name = "Leg Extension", muscle = "Quadricep", category = "Single-Joint"},
                //Hamstring
                new Exercises {name = "Barbell Romanian Deadlift", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Dumbbell Romanian Deadlift", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Stability Ball Glute-Ham Raise", muscle = "Hamstring", category = "Multi-Joint"},
                new Exercises {name = "Leg Curl", muscle = "Hamstring", category = "Single-Joint"},
                //Gluteal
                new Exercises {name = "Barbell Hip Thrust", muscle = "Gluteal", category = "Multi-Joint"},
                new Exercises {name = "Barbell Glute Bridge", muscle = "Gluteal", category = "Multi-Joint"},
                //Calf
                new Exercises {name = "Seated Calf Raise", muscle = "Calf", category = "Single-Joint"},
                new Exercises {name = "Smith Machine Calf Raise", muscle = "Calf", category = "Single-Joint"}
            };
        */}

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
    }

    public class Exercises
    {
        string name;
        string muscle;
        string category;
        int reps;
        float weight;

        public void create(string name, string muscle, string category)
        {
            this.name = name;
            this.muscle = muscle;
            this.category = category;
        }

        public float generate_BMI(int heighttotalIN, int weightLBS)
        {
            float heightM = heighttotalIN * 0.0254;
            float weightKG = weightLBS * 0.454;
            float BMI = weightKG / (heightM * heightM);

            return BMI;
        }

        public void generate_pushday(List<Exercises> push_list)
        {
            List<Exercises> pushday = new List<Exercises>();

            
        }

        public void generate_pullday(List<Exercises> pull_list)
        {
            List<Exercises> pullday = new List<Exercises>();


        }

        public void generate_legday(List<Exercises> leg_list)
        {
            List<Exercises> legday = new List<Exercises>();


        }
    }
}
