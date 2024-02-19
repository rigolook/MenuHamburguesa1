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
    internal class VMRegistrarse : BaseViewModel
    {
        public VMRegistrarse(INavigation naivigation)
        {
            Navigation = naivigation;

        }

        #region Procesos

       

        public async Task Registrar()
        {

            await Navigation.PushAsync(new Login());
        }

        #endregion


        #region Comandos

      
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        #endregion
    }
}
