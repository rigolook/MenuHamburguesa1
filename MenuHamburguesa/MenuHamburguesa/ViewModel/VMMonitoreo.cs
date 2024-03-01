using MenuHamburguesa.Models;
using MenuHamburguesa.Simulacion;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    class VMMonitoreo : BaseViewModel
    {
        #region variables
        private MVentilador[] _Venti = new MVentilador[10];
        public Ventiladoressim _VENTILADORES;//BORRAR
        #endregion

        public VMMonitoreo(INavigation naivigation)
        {
            Navigation = naivigation;



            InsertarSensor(MVentilador ventilador);
        }

        #region Objetos
      
        #endregion
        #region Procesos



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
        public void InsertarSensor(MVentilador ventilador)
        {

            _VENTILADORES.Insertar(ventilador);
        }
        #endregion


        #region Comandos


        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
        public ICommand IrVentiladorescommand => new Command(async () => await IrVentiladores());
        public ICommand IrTemperaturacommand => new Command(async () => await IrTemperaturas());

        public ICommand InsertarSensorcommand => new Command<MVentilador>((p) => InsertarSensor(p));
        #endregion
    }
}