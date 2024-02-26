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
    public class VMVentiladores : BaseViewModel
    {
        #region variables
        public List<MVentilador> _SensoresVentiladores;
        #endregion

        public VMVentiladores(INavigation naivigation)
        {
            Navigation = naivigation;


            ///Esto se quitara despues 
            _SensoresVentiladores = new List<MVentilador>
            {
                new MVentilador { Habitacion = "Cocina", Rpm =$"Rpm: {3200}",Encendido=true},
                new MVentilador { Habitacion = "Cuarto de lavabo", Rpm =$"Rpm: {000}",Encendido=false}
            };
        }

        #region Procesos
        public List<MVentilador> Lista
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
