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
            bindingSet.Bind(btnSettings).For(x => x.Command).To(x => x.GoToSettingsCommand);
            bindingSet.Bind(lblTitle).For(x => x.Text).To(x => x.TitleText);
            bindingSet.Bind(lblCalorieAmt).For(x => x.Text).To(x => x.CaloriesAmount);
            bindingSet.Bind(lblCalorie).For(x => x.Text).To(x => x.CaloriesLabel);
            bindingSet.Bind(lblFatAmt).For(x => x.Text).To(x => x.FatAmount);
            bindingSet.Bind(lblFat).For(x => x.Text).To(x => x.FatLabel);
            bindingSet.Bind(lblCarbAmt).For(x => x.Text).To(x => x.CarbAmount);
            bindingSet.Bind(lblCarb).For(x => x.Text).To(x => x.CarbLabel);
            bindingSet.Bind(lblProteinAmt).For(x => x.Text).To(x => x.ProteinAmount);
            bindingSet.Bind(lblProtein).For(x => x.Text).To(x => x.ProteinLabel);


            bindingSet.Apply();
        }
    }
}