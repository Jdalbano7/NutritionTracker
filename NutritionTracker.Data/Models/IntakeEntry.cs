using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Data.Models
{
    public class IntakeEntry
    {
        public int Calories { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Protein { get; set; }
    }
}
