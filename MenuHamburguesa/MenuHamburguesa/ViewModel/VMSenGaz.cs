using MenuHamburguesa.Models;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    public class VMSenGaz : BaseViewModel
    {
        #region variables
        public List<MSenGaz> _SensoresGaz;
        #endregion

        public VMSenGaz(INavigation naivigation)
        {
            Navigation = naivigation;


            ///Esto se quitara despues 
            _SensoresGaz = new List<MSenGaz>
            {
                new MSenGaz { Habitacion = "Cocina", Gaz ="Monoxido de carbono"},
                new MSenGaz { Habitacion = "Cuarto de lavabo", Gaz ="Dioxido de carbono"}
            };
        }

        #region Procesos
        public List<MSenGaz> Lista
        {
            get { return _SensoresGaz; }
            set
            {
                SetValue(ref _SensoresGaz, value);
                OnpropertyChanged();

            }
        }
        #endregion
        #region Procesos



        public async Task IrSensoresGas()
        {

            await Navigation.PushAsync(new SenGaz());
        }

        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        #endregion
    }
}
