using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XF_Mvvm_Exercicio2.ViewModels
{
    public class AloMvvmViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Nome { get; set; }

        private string _mensagemBoasVindas;

        public string MensagemBoasVindas
        {
            get { return _mensagemBoasVindas; }
            set
            {
                _mensagemBoasVindas = value;
                OnPropertyChanged();
            }
        }

        public Command BoasVindasCommand
        {
            get
            {
                return new Command(()=> 
                {
                    _mensagemBoasVindas = "Seja muito bem-vindo" + Nome;
                });
            }
        }
    }
}
           

          



