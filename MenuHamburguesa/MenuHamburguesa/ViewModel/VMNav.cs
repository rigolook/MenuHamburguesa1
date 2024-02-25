using MenuHamburguesa.Models;
using MenuHamburguesa.Views;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    public class VMNav : BaseViewModel
    {
        #region variables
       

        #endregion

        public VMNav(INavigation naivigation)
        {
            Navigation = naivigation;
        }

        #region Objetos
      
        #endregion


        #region Procesos



        public async Task GoInicio()
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Inicio());
        }

        public async Task GoMonitoreo()
        {

            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Monitoreo());
        }
        public async Task GoRegistro()
        {

            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Registro());
        }
        public async Task GoConfig()
        {

            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new configuracion());
        }
        public async Task GoCerrarSesior()
        {

            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Login());
        }
        #endregion


        #region Comandos


        public ICommand IrIniciocommand => new Command(async () => await GoInicio());
        public ICommand IrMonitoreocommand => new Command(async () => await GoMonitoreo());
        public ICommand IrRegistrocommand => new Command(async () => await GoRegistro());
        public ICommand IrConfcommand => new Command(async () => await GoConfig());
        public ICommand IrCerrarSesiorcommand => new Command(async () => await GoCerrarSesior());

        #endregion
    }
}