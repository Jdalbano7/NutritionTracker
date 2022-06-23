using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using NutritionTracker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Font Awesome 6 Brands-Regular-400.otf", Alias = "FAB")]
[assembly: ExportFont("Font Awesome 6 Free-Regular-400.otf", Alias = "FAR")]
[assembly: ExportFont("Font Awesome 6 Free-Solid-900.otf", Alias = "FAS")]

namespace NutritionTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
    }
}
