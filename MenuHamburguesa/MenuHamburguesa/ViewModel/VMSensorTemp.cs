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
    public class VMSensorTemp : BaseViewModel
    {
        #region variables
        public List<MSenTemp> _SensoresVentiladores;
        #endregion

        public VMSensorTemp(INavigation naivigation)
        {
            Navigation = naivigation;


            ///Esto se quitara despues 
            _SensoresVentiladores = new List<MSenTemp>
            {
                new MSenTemp { Habitacion = "Cocina", Temp =$"Temperatura: {32}°",Humedad=$"Humedad: {30}%" },
                new MSenTemp { Habitacion = "Cuarto de lavabo", Temp =$"Temperatura: {16}",Humedad=$"Humedad: {30}%"}
            };
        }

        #region Procesos
        public List<MSenTemp> Lista
        {
            get { return _SensoresVentiladores; }
            set
            {
                SetValue(ref _SensoresVentiladores, value);
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
