using MvvmCross.Forms.Views;
using NutritionTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutritionTracker.Views
{
    public partial class HomeView : MvxContentPage<HomeViewModel>
    {
        public HomeView()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Bind();
            base.OnAppearing();

        }

        private void Bind()
        {
            var bindingSet = CreateBindingSet();
            bindingSet.Apply();
        }
    }
}