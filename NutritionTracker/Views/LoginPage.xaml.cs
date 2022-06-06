using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using MvvmCross.Views;
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
    public partial class LoginPage : MvxContentPage<LoginViewModel>
    {
        public LoginPage()
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
            bindingSet.Bind(btnLogin).For(btn => btn.Command).To(vm => vm.LoginCommand);
            bindingSet.Bind(btnLogin).For(btn => btn.Text).To(vm => vm.LoginText);
            bindingSet.Apply();
        }

    }
}