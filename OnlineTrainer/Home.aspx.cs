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
            //Pectorals
            exercises.create("Flat Barbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Incline Barbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Decline Barbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Flat Dumbbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Incline Dumbbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Decline Dumbbell Chest Press", "Chest", "Multi-Joint");
            exercises.create("Flat Dumbbell Chest Fly", "Chest", "Single-Joint");
            exercises.create("Incline Dumbbell Chest Fly", "Chest", "Single-Joint");
            exercises.create("Decline Dumbbell Chest Fly", "Chest", "Single-Joint");
            exercises.create("Standard Cable Chest Fly", "Chest", "Single-Joint");
            exercises.create("Incline Cable Chest Fly", "Chest", "Single-Joint");
            exercises.create("Decline Cable Chest Fly", "Chest", "Single-Joint");
            //Deltoids
            exercises.create("Seated Barbell Overhead Press", "Shoulder", "Multi-Joint");
            exercises.create("Standing Barbell Overhead Press", "Shoulder", "Multi-Joint");
            exercises.create("Seated Dumbbell Overhead Press", "Shoulder", "Multi-Joint");
            exercises.create("Standing Dumbbell Overhead Press", "Shoulder", "Multi-Joint");
            exercises.create("Dumbbell Side Lateral Raise", "Shoulder", "Single-Joint");
            exercises.create("Cable Side Lateral Raise", "Shoulder", "Single-Joint");
            exercises.create("Dumbbell Front Raise", "Shoulder", "Single-Joint");
            exercises.create("Cable Front Raise", "Shoulder", "Single-Joint");
            //Triceps
            exercises.create("Close-Grip Barbell Chest Press", "Tricep", "Multi-Joint");
            exercises.create("Medicine Ball Pushup", "Tricep", "Multi-Joint");
            exercises.create("Diamond Pushup", "Tricep", "Multi-Joint");
            exercises.create("Dumbell Kickback", "Tricep", "Single-Joint");
            exercises.create("Cable Kickback", "Tricep", "Single-Joint");
            exercises.create("Dumbbell Skullcrusher", "Tricep", "Single-Joint");
            exercises.create("EZ-Bar Skullcrusher", "Tricep", "Single-Joint");
            exercises.create("Cable Tricep Pushdown", "Tricep", "Single-Joint");

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
