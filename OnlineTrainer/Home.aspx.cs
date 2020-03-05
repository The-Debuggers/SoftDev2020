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
            exercises.create();
            exercises.create();
            exercises.create();
            exercises.create();
            exercises.create();
            exercises.create();
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
    }

}
