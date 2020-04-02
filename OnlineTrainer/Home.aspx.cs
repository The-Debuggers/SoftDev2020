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
                new Exercises {name = "Cable Tricep Pushdown", muscle = "Tricep", category = "Single-Joint"},
            };

            //Pull day exercises
            
            
            //Back
            exercises.create("Pull-ups", "Back", "Multi-Joint");
            exercises.create("Lat Pulldown", "Back", "Multi-Joint");
            exercises.create("Seated Cable Row", "Back", "Multi-Joint");
            exercises.create("Bent-Over Barbell Row", "Back", "Multi-Joint");
            exercises.create("Bent-Over Dumbbell Row", "Back", "Multi-Joint");
            exercises.create("T-Bar Row", "Back", "Multi-Joint");
            exercises.create("Facepulls", "Back", "Multi-Joint");
            exercises.create("Dumbbell Reverse Fly", "Back", "Single-Joint");
            exercises.create("Cable Reverse Fly", "Back", "Single-Joint");
            //Biceps
            exercises.create("Chin-ups", "Bicep", "Multi-Joint");
            exercises.create("Standing Dumbbell Curl", "Bicep", "Single-Joint");
            exercises.create("Seated Dumbbell Curl", "Bicep", "Single-Joint");
            exercises.create("Standing Dumbbell Hammer Curl", "Bicep", "Single-Joint");
            exercises.create("Seated Dumbbell Hammer Curl", "Bicep", "Single-Joint");
            exercises.create("Seated Incline Dumbbell Curl", "Bicep", "Single-Joint");
            exercises.create("Dumbbell Preacher Curl", "Bicep", "Single-Joint");
            exercises.create("EZ-Bar Preacher Curl", "Bicep", "Single-Joint");
            exercises.create("Standing EZ-Bar Curl", "Bicep", "Single-Joint");
            exercises.create("Standing Barbell Curl", "Bicep", "Single-Joint");
            exercises.create("Standing Cable Curl", "Bicep", "Single-Joint");

            //Leg day exercises
            //Quadricep
            exercises.create("Barbell Back Squat", "Quadricep", "Multi-Joint");
            exercises.create("Goblet Squat", "Quadricep", "Multi-Joint");
            exercises.create("Dumbbell Bulgarian Split Squat", "Quadricep", "Multi-Joint");
            exercises.create("Dumbbell Lunge", "Quadricep", "Multi-Joint");
            exercises.create("Leg Press", "Quadricep", "Multi-Joint");
            exercises.create("Leg Extension", "Quadricep", "Single-Joint");
            //Hamstring
            exercises.create("Barbell Romanian Deadlift", "Hamstring", "Multi-Joint");
            exercises.create("Dumbbell Romanian Deadlift", "Hamstring", "Multi-Joint");
            exercises.create("Stability Ball Glute-Ham Raise", "Hamstring", "Multi-Joint");
            exercises.create("Leg Curl", "Hamstring", "Single-Joint");
            //Gluteal
            exercises.create("Barbell Hip Thrust", "Gluteal", "Multi-Joint");
            exercises.create("Barbell Glute Bridge", "Gluteal", "Multi-Joint");
            //Calf
            exercises.create("Seated Calf Raise", "Calf", "Single-Joint");
            exercises.create("Smith Machine Calf Raise", "Calf", "Single-Joint");
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

        public void generate_push()
        {

        }
    }

}
