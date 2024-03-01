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
    public class VMInicio : BaseViewModel
    {
        #region variables
        public List<MSenGaz> _SensoresTemp;
        #endregion

        public VMInicio(INavigation naivigation)
        {
            Navigation = naivigation;


            ///Esto se quitara despues 
            _SensoresTemp = new List<MSenGaz>
            {
                new MSenGaz { Habitacion = "Cocina", Gaz ="Monoxido de carbono"},
                new MSenGaz { Habitacion = "Cuarto de lavabo", Gaz ="Dioxido de carbono"}
            };
        }

        #region OBJETOS
        public List<MSenGaz> Lista
        {
            get { return _SensoresTemp; }
            set
            {
                SetValue(ref _SensoresTemp, value);
                OnpropertyChanged();

            }
        }
        #endregion
        #region PROCESO



        public async Task IrSensoresGas()
        {

            await Navigation.PushAsync(new SenGaz());
        }

        public async Task IrVentiladores()
        {

            await Navigation.PushAsync(new Ventiladores());
        }
        public async Task IrTemperaturas()
        {

            await Navigation.PushAsync(new SenosorTemp());
        }
        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        public ICommand IrVentiladorescommand => new Command(async () => await IrVentiladores());
        public ICommand IrTemperaturacommand => new Command(async () => await IrTemperaturas());
        #endregion
    }
}
