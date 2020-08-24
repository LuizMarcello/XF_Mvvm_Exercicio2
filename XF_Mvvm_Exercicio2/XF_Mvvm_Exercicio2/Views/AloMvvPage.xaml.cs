using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_Mvvm_Exercicio2.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Mvvm_Exercicio2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AloMvvPage : ContentPage
    {
        public AloMvvPage()
        {
            //InitializeComponent();

            this.BindingContext = new AloMvvmViewModel();
        }
    }
}