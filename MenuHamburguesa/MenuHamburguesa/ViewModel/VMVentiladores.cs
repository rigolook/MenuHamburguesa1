using MenuHamburguesa.Models;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MenuHamburguesa.Simulacion;
using System.Collections;

namespace MenuHamburguesa.ViewModel
{
    public class VMVentiladores : BaseViewModel
    {
        #region variables
        public MVentilador[] _SensoresVentiladores = new MVentilador[10];
        public Ventiladoressim _VENTILADORES;//BORRAR
        public MVentilador[] kk = new MVentilador[10];
        #endregion

        public VMVentiladores(INavigation navigation)
        {
            Navigation = navigation;
          
            ListarVentiladores();
        }

        #region Procesos
        public MVentilador[] Lista
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
       
        public void ListarVentiladores()
        {
           
          

            _VENTILADORES = Ventiladoressim.Instancia;
            Lista = _VENTILADORES.ObtenerAreglo();
        }

        #endregion


        #region Comandos
        public ICommand IrSensoresGascommand => new Command(async () => await IrSensoresGas());
       
        #endregion

    }
}
