using MvvmCross.Commands;
using MvvmCross.Navigation;
using NutritionTracker.Core.Services.Interface;
using NutritionTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionTracker.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IIntakeEntryService _intakeEntryService;

        public HomeViewModel(
            IMvxNavigationService navigationService,
            IIntakeEntryService intakeEntryService) : base(navigationService)
        {
            _intakeEntryService = intakeEntryService; 

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

        private List<IntakeEntry> _intakeEntries;
        private List<IntakeEntry> IntakeEntries
        {
            get => _intakeEntries ?? new List<IntakeEntry>();
            set
            {
                _intakeEntries = value;
                RaisePropertyChanged(nameof(CaloriesAmount));
                RaisePropertyChanged(nameof(FatAmount));
                RaisePropertyChanged(nameof(CarbAmount));
                RaisePropertyChanged(nameof(ProteinAmount));
            }
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();

            IntakeEntries = _intakeEntryService.GetIntakeEntries();
        }

        private void GoToSettings()
        {
            _navigationService.Navigate<SettingsViewModel>();
        }
    }
}
