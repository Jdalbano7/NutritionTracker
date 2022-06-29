using NutritionTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.Services.Interface
{
    public interface IIntakeEntryService
    {
        List<IntakeEntry> GetIntakeEntries();
    }
}
