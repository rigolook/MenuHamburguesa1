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
        public VMLogin(INavigation naivigation)
        {
            Navigation = naivigation;

        }

        #region Procesos

        public async Task IniciarSecion()
        {

            await Navigation.PushAsync(new MainPage());
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
