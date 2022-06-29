using MvvmCross;
using MvvmCross.ViewModels;
using NutritionTracker.Core.Services.Implementation.Mock;
using NutritionTracker.Core.Services.Interface;
using NutritionTracker.Core.ViewModels;

namespace NutritionTracker.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterServices();
            RegisterAppStart<LoginViewModel>();
        }

        private void RegisterServices()
        {
            Mvx.IoCProvider.RegisterType<IIntakeEntryService, MockIntakeEntryService>();
        }
    }
}
