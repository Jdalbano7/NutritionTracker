using MvvmCross.ViewModels;
using NutritionTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart<LoginViewModel>();


        }

    }
}
