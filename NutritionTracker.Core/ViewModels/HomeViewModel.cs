using MvvmCross.Commands;
using MvvmCross.Navigation;
using NutritionTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace NutritionTracker.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
            GoToSettingsCommand = new MvxCommand(GoToSettings);
        }

        public IMvxCommand GoToSettingsCommand { get; set; }

        public string TitleText => "Nutrition Tracker";
        public int CaloriesAmount => IntakeEntries.Sum(x => x.Calories);
        public string CaloriesLabel => "cal";
        public int FatAmount => IntakeEntries.Sum(x => x.Fat);
        public string FatLabel => "Fats";
        public int CarbAmount => IntakeEntries.Sum(x => x.Carbs);
        public string CarbLabel => "Carbs";
        public int ProteinAmount => IntakeEntries.Sum(x => x.Protein);
        public string ProteinLabel => "Protein";

        private List<IntakeEntry> IntakeEntries => new List<IntakeEntry>
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

        private void GoToSettings()
        {
            _navigationService.Navigate<SettingsViewModel>();
        }
    }
}
