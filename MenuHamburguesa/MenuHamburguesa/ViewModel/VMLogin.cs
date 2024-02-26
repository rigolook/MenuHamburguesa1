using AirePuro.View;
using MenuHamburguesa.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    internal class VMLogin : BaseViewModel
    {
        private string _Mensaje;
        public VMLogin(INavigation naivigation)
        {
            Navigation = naivigation;

        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set
            {
                _Mensaje = value;
                OnPropertyChanged();
            }
        }
        #region Procesos

        public async Task IniciarSecion()
        {

            await Navigation.PushAsync(new MainPage());
            Mensaje = "Haz iniciado sesion con exito";

        }

        public async Task Registrar()
        {

            await Navigation.PushAsync(new Registrarte());
        }

        #endregion


        #region Comandos

        public ICommand Iniciarcommand => new Command(async () => await IniciarSecion());
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        #endregion
    }
}
