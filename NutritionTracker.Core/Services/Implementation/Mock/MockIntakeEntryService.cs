using NutritionTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.Services.Implementation.Mock
{
    internal class MockIntakeEntryService
    {
        public List<IntakeEntry> GetIntakeEntries()
        {

            return new List<IntakeEntry>
            {
                new IntakeEntry
                {
                    Calories = 1000,
                    Fat = 518,
                    Protein = 20,
                    Carbs = 59,
                },
                new IntakeEntry
                {
                    Calories = 223,
                    Fat = 23,
                    Protein = 240,
                    Carbs = 5229,
                },
            };
        }
    }
}
