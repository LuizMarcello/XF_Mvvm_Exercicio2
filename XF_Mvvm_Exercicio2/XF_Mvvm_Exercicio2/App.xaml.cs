using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Mvvm_Exercicio2.ViewModels;
using XF_Mvvm_Exercicio2.Views;

namespace XF_Mvvm_Exercicio2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AloMvvPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
