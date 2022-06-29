using NutritionTracker.Core.Services.Interface;
using NutritionTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.Services.Implementation.Mock
{
    internal class MockIntakeEntryService : IIntakeEntryService
    {
        public List<IntakeEntry> GetIntakeEntries()
        {

            return new List<IntakeEntry>
            {
                new IntakeEntry
                {
                    Calories = 17,
                    Fat = 17,
                    Protein = 17,
                    Carbs = 17,
                },
                new IntakeEntry
                {
                    Calories = 7,
                    Fat = 7,
                    Protein = 7,
                    Carbs = 7,
                },
            };
        }
    }
}
